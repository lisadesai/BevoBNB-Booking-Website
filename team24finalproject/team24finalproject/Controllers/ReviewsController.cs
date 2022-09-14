using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Team24_Final_Project.DAL;
using Team24_Final_Project.Models;

namespace Team24_Final_Project.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly AppDbContext _context;

        public ReviewsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reviews
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reviews.ToListAsync());
        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .FirstOrDefaultAsync(m => m.ReviewID == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // GET: Reviews/Create
        //must send this method a property id, put route value wherever the link to create a review is located
        public IActionResult Create(int propertyID)
        {

             Review review = new Review();

            //find the property that should be associated with this review
            Property dbProperty = _context.Properties.Find(propertyID);


            //AppUser dbUser = _context.Users.FirstOrDefault(r => r.Email == User.Identity.Name);
            //set the review's property equal to the property you just found
            review.Property = dbProperty;
            //review.User = dbUser;

            //TODO:check if person has stayed there or is going to stay there. if not, send to error page
            var stayCount = _context.Reservations
                                    .Where(pp => pp.Property.PropertyID == propertyID &&
                                                 pp.Order.User.UserName == User.Identity.Name &&   
                                                 pp.Status == ReservationStatus.Confirmed) 
                                    .Count();

            //if not stayed there before, go to error page. else, 
            if (stayCount == 0)
            {
                return View("Error", new String[] { "You cannot review this property because there is no reservation on account" });
            }


            //TODO:if they are now allowed to review, check if they have ever left a review before
            //get a list of the reviews that belong to this property with this user
            var reviewCount = _context.Reviews
                                          .Include(rv => rv.Property)
                                          .Where(rv => rv.Property.PropertyID == propertyID && rv.User.UserName == User.Identity.Name)
                                          .Count();



            //if no review left before, go ahead to create view, else, go to error page.
            if (reviewCount == 0)
            {
                return View(review);
            }
            else
            {
                return View("Error", new String[] { "You have already reviewed this property" });

            }

        }

        // POST: Reviews/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Review review, int PropertyID)
        {


           

            //find the property on the database that has the correct property id
            Property dbProperty = _context.Properties.Find(review.Property.PropertyID);

            //set the property on the review equal to the property that we just found
            review.Property = dbProperty;
            review.User = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            //review.Property.City = dbProperty.City;
            //review.Property.State = dbProperty.State;
            //    ///zip/address
      

            if (review.Rating <= 0 || review.Rating >= 6)
            {
                return View("Error", new String[] { "Your review must be between 1 and 5, inclusive. " });

            }



            //call the calc avg rating function
            review.Property.CalcAvgRating();

            //add the review to the database
            _context.Add(review);
            await _context.SaveChangesAsync();


            return RedirectToAction("ReviewConfirmed", "Reviews");
        }

        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //user did not specify a review to edit
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a review to edit!" });
            }

            //find the review to edit
            Review review = await _context.Reviews
                                      .Include(r => r.Property)
                                      .Include(r => r.User) //added todayyy
                                      .FirstOrDefaultAsync(r => r.ReviewID == id);

            //make sure it was written by person logged in
            if (review.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "You didn't write this review so you can't edit it!" });

            }

            if (review == null)
            {
                return View("Error", new String[] { "This review was not found. Where even are you??" });
            }

            if (review.DisputeStatus != DisputeStatusEnum.Open)
            {
                return View("Error", new String[] { "This review is not open for editing because it is in the dispute process." });

            }

            return View(review);
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Review review)
        {

            //Associate the review with the logged-in customer
            review.User = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            //review does not belong to this user
            //check if the property they are trying to review is associated with their orders
            if (User.IsInRole("Customer") && review.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "You are not authorized to review this property!" });
            }

            //make sure they are editing correct review
            if (id != review.ReviewID)
            {
                return View("Error", new String[] { "There was a problem editing this review. Try again!" });
            }

            //information is not valid, try again
            if (ModelState.IsValid == false)
            {
                return View(review);
            }

            

            //create a new review object

            //if code gets this far, update the record
            try
            {
                //find the existing review in the database
                //include both registration and course
                Review dbRV = _context.Reviews
                      .Include(rd => rd.Property)
                      .Include(rd => rd.User)
                      .FirstOrDefault(rd => rd.ReviewID == review.ReviewID);

                //update the scalar properties
                dbRV.Rating = review.Rating;
                dbRV.CustomerComment = review.CustomerComment;
                dbRV.DisputeStatus = DisputeStatusEnum.Pending;

                //save changes
                _context.Reviews.Update(dbRV);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem disputing this review", ex.Message });
            }

            //if code gets this far, go back to the registration details index page
            return RedirectToAction("ReviewConfirmed", "Reviews");  //send to confirmation page //new { id = dbRV.Property.PropertyID}

        }


        // GET: Reviews/Confirmation Page
        public async Task<IActionResult> ReviewConfirmed()
        {

            return View();
        }

        //GET Reviews/Dispute
        public async Task<IActionResult> Dispute(int? id)
        {

            //user did not specify a review to dispute
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a review to dispute!" });
            }

            //make sure they are the host for the property being disputed. this is the db review object storing review for host's property
            //Review dbReview = _context.Reviews.FirstOrDefault(r => r.Property.User.UserName == User.Identity.Name && r.ReviewID == id);




            ///////////////
            //find the review in the database
            Review dbReview = await _context.Reviews.Include(c => c.Property)
                                                   .ThenInclude(c => c.User)
                                                  .FirstOrDefaultAsync(c => c.ReviewID == id);

            //check that this review is on a property the host owns
            if (dbReview.Property.User.UserName != User.Identity.Name)
            {
                return View("Error", new string[] { "You're not the host so you can't dispute this property!" });

            }
            /////////////


            //if dbReview is null, meaning there is no review OR theyre not the host bc the property.user != identity.user 
            if (dbReview == null)
            {
                return View("Error", new String[] { "There is no review for this property" });

            }

            //if they are a host, and the host of the property associated w the review isn't who is logged in, throw error
            //if (User.IsInRole("Host") && dbReview.Property.User.UserName != User.Identity.Name)
            //{
            //    return View("Error", new String[] { "You are not authorized to dispute this review!" });
            //}

            ////find the review to dispute
            //Review review = await _context.Reviews
            //                .Include(rv => rv.Property)
            //                .FirstOrDefaultAsync(rv => rv.ReviewID == id);

            if (dbReview.DisputeStatus == DisputeStatusEnum.Closed || dbReview.DisputeStatus == DisputeStatusEnum.Disputed)
            {
                return View("Error", new String[] { "The status of this review is not open for disputes!" });

            }

            return View(dbReview);
        }

        

            //POST Reviews/Dispute
            [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Dispute(int id, Review review)
        {
            //make sure they are the host for the property being disputed
            Review dbRV = _context.Reviews.FirstOrDefault(r => r.Property.User.UserName == User.Identity.Name && r.ReviewID == id);

            // go retrieve the review object based on route value id passed in
            //create a new review object

            //if code gets this far, update the record
            try
            {
                //find the existing review in the database
                //include both registration and course
                dbRV = _context.Reviews
                      .Include(rd => rd.Property)
                      .Include(rd => rd.User)
                      .FirstOrDefault(rd => rd.ReviewID == review.ReviewID);

                //update the scalar properties
                dbRV.HostResponse = review.HostResponse;
                dbRV.DisputeStatus = DisputeStatusEnum.Disputed; 

                //save changes
                _context.Update(dbRV);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this review", ex.Message });
            }




            return RedirectToAction("ReviewConfirmed", "Reviews"); 
        }



        ///
        /// /////
        /// //////
        ///
        ///
        /// /
        /// 



        [Authorize(Roles = "Admin")]
        //GET ResolveDispute, for admins to accept or reject the dispute
        public async Task<IActionResult> ResolveDispute(int? id)
        {


            //user did not specify a review to resolve
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a review to resolve!" });
            }

            //make sure there is a review to dispute in the first place
            //Review dbReview = _context.Reviews.FirstOrDefault(r => r.ReviewID == id);

            

            //find the review to edit
            Review review = await _context.Reviews
                            .Include(rv => rv.Property)
                            .Include(rv => rv.User)
                            .FirstOrDefaultAsync(rv => rv.ReviewID == id);


            //if dbReview is null, meaning there is no review to dispute OR it's not pending
            if (review.DisputeStatus != DisputeStatusEnum.Disputed)
            {
                return View("Error", new String[] { "There is no dispute to resolve for this property" });

            }



            if (review == null)
            {
                return View("Error", new String[] { "This review was not found" });
            }


            return View(review);
        }


        // POST: Reviews/ResolveDispute/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResolveDispute(int id, Review review)
        {


            //user did not specify a review to dispute
            if (review == null)
            {
                return View("Error", new String[] { "Please specify a review to resolve!" });
            }

            try
            {
                if (review.AcceptReject == true) //they check the box and ACCEPT, siding with host
                {
                    review.DisputeStatus = DisputeStatusEnum.Closed;

                    //delete the review (remove from DB)
                    _context.Reviews.Remove(review);
                    await _context.SaveChangesAsync();
                }
                else //they leave it blank and DECLINE, siding with guest
                {
                    //find db review and update scalar prop
                    Review dbRV = _context.Reviews
                     .Include(rd => rd.Property)
                     .Include(rd => rd.User)
                     .FirstOrDefault(rd => rd.ReviewID == review.ReviewID);

                    //update the scalar properties
                    dbRV.DisputeStatus = DisputeStatusEnum.Closed;

                    //update db
                    _context.Update(dbRV);
                    await _context.SaveChangesAsync();

                                                        //review is not deleted just closed, flag is still false so it will factor into average rating
                }

            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this review", ex.Message });
            }


            return RedirectToAction("Index", "Reviews");
        }


        //[Authorize(Roles = "Admin")]
        //// GET: Reviews/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return View("Error", new String[] { "The review you are trying to delete doesn't exist. " });
        //    }

        //    //find the review to delete
        //    Review review = await _context.Reviews
        //                    .Include(rv => rv.Property)
        //                    .FirstOrDefaultAsync(rv => rv.ReviewID == id);

            
        //    if (review == null)
        //    {
        //        return View("Error", new String[] { "This review was not found" });
        //    }

            

        //    return View(review);
        //}

        //[Authorize(Roles = "Admin")]
        //// POST: Reviews/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var review = await _context.Reviews.FindAsync(id);
        //    _context.Reviews.Remove(review);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index)); //TODO: send them to a delete confirmation page instead
        //}

        private bool ReviewExists(int id)
        {
            return _context.Reviews.Any(e => e.ReviewID == id);
        }
    }
}
