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
using Team24_Final_Project.Models.ViewModels;

namespace Team24_Final_Project.Controllers
{
    //[Authorize(Roles != "Host")]
    public class PropertiesController : Controller
    {
        private readonly AppDbContext _context;
        //private DateTime? startBorder = null;
        //private DateTime? endBorder = null;

        public PropertiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Properties
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
           

            var query = from b in _context.Properties select b;          //Linq query that helps select from book table

            //if (String.IsNullOrEmpty(SearchString) == false)
            //{
            //    query = query.Where(b => b.Title.Contains(SearchString) ||
            //                              b.Description.Contains(SearchString));

            //}


            List<Property> SelectedProperties = query.Include(b => b.Category)
                                                    .Include(b => b.Reviews)
                                                    .Where(b => b.PropertyStatus == PropertyStatusEnum.Active)
                                                    .ToList();

            //calc avg rating for each property in the selected properties list
            foreach (Property property in SelectedProperties)
            {
                property.CalcAvgRating();
            }





            //Populate the view bag with a count of all books
            ViewBag.AllProperties = _context.Properties.Where(p => p.PropertyStatus == PropertyStatusEnum.Active)
                                                        .Count();

            //Populate the view bag with a count of selected books
            ViewBag.SelectedProperties = SelectedProperties.Count();


            return View(SelectedProperties.OrderBy(s => s.PropertyNumber));

        }

        public async Task<IActionResult> SearchResults()
        {


            var query = from b in _context.Properties select b;          //Linq query that helps select from book table

            //if (String.IsNullOrEmpty(SearchString) == false)
            //{
            //    query = query.Where(b => b.Title.Contains(SearchString) ||
            //                              b.Description.Contains(SearchString));

            //}


            List<Property> SelectedProperties = query.Include(b => b.Category).Include(b => b.Reviews).ToList();

            //calc avg rating for each property in the selected properties list
            foreach (Property property in SelectedProperties)
            {
                property.CalcAvgRating();
            }

            //Populate the view bag with a count of all books
            ViewBag.AllProperties = _context.Properties.Count();

            //Populate the view bag with a count of selected books
            ViewBag.SelectedProperties = SelectedProperties.Count();


            return View(SelectedProperties.OrderBy(s => s.PropertyNumber));

        }


        // GET: Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) //BookID not specified
            {
                //user did not specify a BookID – take them to the error view
                return View("Error", new String[] { "PropertyID not specified - which property do you want to view?" });
            }

            //look up the property in the database based on the id; be sure to include the category
            Property property = _context.Properties.Include(b => b.Category).Include(b => b.Reviews)
                                      .FirstOrDefault(b => b.PropertyID == id);
            
            //calc avg rating for each property in the selected properties list
            property.CalcAvgRating();

            if (property == null) //No property with this id exists in the database
            {
                //there is not a property with this id in the database – show the user an error view
                return View("Error", new String[] { "Property not found in database" });
            }

            //if code gets this far, all is well – display the details
            return View(property);
        }

        // GET: Properties/Create
        public IActionResult Create()
        {
            ViewBag.AllCategories = GetAllCategories();

            return View();
        }


        //GetAllCategories for the Properties/CREATE view
        private SelectList GetAllCategories()
        {
            //Get the list of months from the database
            List<Category> categoryList = _context.Categories.ToList();

            //add a dummy entry so the user can select all months. NOTE: dummy entry not needed for the CREATE, but needed for search. 
            // Category SelectNone = new Category() { CategoryID = 0, CategoryName = "Any Category" };
            // categoryList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //MonthID and MonthName are the names of the properties on the Month class
            //MonthID is the primary key
            SelectList categorySelectList = new SelectList(categoryList.OrderBy(m => m.CategoryID), "CategoryID", "CategoryName");

            //return the electList
            return categorySelectList;
        }

        //GetAllCategories for the Properties/SEARCH VIEW MODEL
        private SelectList GetAllCategoriesSearch()
        {
            //Get the list of months from the database
            List<Category> categoryList = _context.Categories.ToList();

            //add a dummy entry so the user can select all months. NOTE: dummy entry not needed for the CREATE, but needed for search. 
            Category SelectNone = new Category() { CategoryID = 0, CategoryName = "Any Category" };
            categoryList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //MonthID and MonthName are the names of the properties on the Month class
            //MonthID is the primary key
            SelectList categorySelectList = new SelectList(categoryList.OrderBy(m => m.CategoryID), "CategoryID", "CategoryName");

            //return the electList
            return categorySelectList;
        }




        // POST: Properties/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Property property, int SelectedCategory)
        {
            //Set the value for the PropertyNumber
            property.PropertyNumber = Utilities.GeneratePropertyNumber.GetNextPropertyNumber(_context);

            if (ModelState.IsValid == false)
            {
                //go back to the Create view to try again
                ViewBag.AllCategories = GetAllCategories();
                return View(property);
            }

            ////find the cat on the database that has the correct cat id
            Category dbCategory = _context.Categories.Find(SelectedCategory);

            ////set the cat on the property equal to the cat that we just found
            property.Category = dbCategory;

            //set approval to pending bc admin must approve it. property could be approved and inactive or active, so i needed separate enum. 
            property.AdminReview = AdminApprovalEnum.Pending;
            property.PropertyStatus = PropertyStatusEnum.Pending;

            //assign user (host) as the one who is currently logged in
            property.User = await _context.Users.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);


            _context.Add(property);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }






        //GET approve property. displays all props to approve.
        [Authorize(Roles ="Admin")]
        public IActionResult ApproveProperty()
        {
            // get all properties with pending status
            List<Property> pendingProps = _context.Properties.Include(p => p.Category)
                                                            .Include(p => p.Reviews)
                                                            .Where(p => p.PropertyStatus == PropertyStatusEnum.Pending).ToList();
            //calc ratings 
            foreach (Property property in pendingProps)
            {
                property.CalcAvgRating();
            }

            //var query = from b in _context.Properties select b;          //Linq query that helps select from book table

            ////populate viewbag!
            //List<Property> SelectedProperties = query.Include(b => b.Category)
            //                                        .Include(b => b.Reviews)
            //                                        .Where(b => b.PropertyStatus == PropertyStatusEnum.Active)
            //                                        .ToList();

            ////calc avg rating for each property in the selected properties list
            //foreach (Property property in SelectedProperties)
            //{
            //    property.CalcAvgRating();
            //}

            ////Populate the view bag with a count of all books      
            //ViewBag.AllProperties = _context.Properties.Where(p => p.PropertyStatus == PropertyStatusEnum.Active)
            //                                           .Count();

            ////Populate the view bag with a count of selected books
            //ViewBag.SelectedProperties = SelectedProperties.Count();

            return View("Index", pendingProps.OrderBy(p => p.PropertyNumber) );
        }

        //GET approve. view for admin to literally approve.
        [Authorize(Roles = "Admin")]
        public IActionResult Approve(int id)
        {
            //check if prop id
            if (id == null) 
            {
                
                return View("Error", new String[] { "PropertyID not specified - which property do you want to approve?" });
            }

            


            //APPROVE IT AND ACTIVATE
            try
            {
                //find the existing prop in the database
                Property dbProperty = _context.Properties.Include(r => r.Category)
                                                            .Include(r => r.Reviews)
                                                            .FirstOrDefault(r => r.PropertyID == id);
                if (dbProperty.PropertyStatus != PropertyStatusEnum.Pending)
                {
                    return View("Error", new String[] { "This property doesn't need approval" });

                }

                //update the scalar properties
                dbProperty.PropertyStatus = PropertyStatusEnum.Active;
                dbProperty.AdminReview = AdminApprovalEnum.Approved;

                //save changes
                _context.Update(dbProperty);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this review", ex.Message });
            }


            ////get all properties with pending status
            //List<Property> pendingProps = _context.Properties.Include(p => p.Category)
            //                                                .Include(p => p.Reviews)
            //                                                .Where(p => p.PropertyStatus == PropertyStatusEnum.Pending).ToList();
            ////calc ratings 
            //foreach (Property property in pendingProps)
            //{
            //    property.CalcAvgRating();
            //}

            ////send them back to continue the process
            //return RedirectToAction("Index", pendingProps.OrderBy(p => p.PropertyNumber));

            return RedirectToAction("Index");
        }

        //GET approve. view for admin to literally approve.
        [Authorize(Roles = "Admin")]
        public IActionResult Deny(int id)
        {

            if (id == null)
            {

                return View("Error", new String[] { "PropertyID not specified - which property do you want to approve?" });
            }

            

            //DENY IT AND INACTIVATE IT
            try
            {
                //find the existing prop in the database
                Property dbProperty = _context.Properties.Include(r => r.Category)
                                                            .Include(r => r.Reviews)
                                                            .FirstOrDefault(r => r.PropertyID == id);
                if (dbProperty.PropertyStatus != PropertyStatusEnum.Pending)
                {
                    return View("Error", new String[] { "This property doesn't need approval" });

                }

                //update the scalar properties
                dbProperty.PropertyStatus = PropertyStatusEnum.Inactive;
                dbProperty.AdminReview = AdminApprovalEnum.NotApproved;

                //save changes
                _context.Update(dbProperty);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this review", ex.Message });
            }


            ////get all properties with pending status
            //List<Property> pendingProps = _context.Properties.Include(p => p.Category)
            //                                                    .Include(p => p.Reviews)
            //                                                    .Where(p => p.PropertyStatus == PropertyStatusEnum.Pending).ToList();
            ////calc ratings 
            //foreach (Property property in pendingProps)
            //{
            //    property.CalcAvgRating();
            //}

            ////send them back to continue the process
            //return RedirectToAction("Index", pendingProps.OrderBy(p => p.PropertyNumber));

            return RedirectToAction("Index");
        }

















        //GET approve. button for admin to literally approve.
        [Authorize(Roles = "Host")]
        public IActionResult Activate(int id)
        {
            //check if prop id
            if (id == null)
            {

                return View("Error", new String[] { "PropertyID not specified - which property do you want to activate?" });
            }

            //APPROVE IT AND ACTIVATE
            try
            {
                //find the existing prop in the database
                Property dbProperty = _context.Properties.Include(r => r.Category)
                                                            .Include(r => r.Reviews)
                                                            .Include(r => r.User)
                                                            .FirstOrDefault(r => r.PropertyID == id);

                 if (dbProperty.User.Email != User.Identity.Name)
                {
                    return View("Error", new String[] { "This isn't your property to activate/deactivate" });

                }

                if (dbProperty.AdminReview != AdminApprovalEnum.Approved)
                {
                    return View("Error", new String[] { "This property can't be activated since it's not approved" });

                }

                if (dbProperty.PropertyStatus != PropertyStatusEnum.Inactive)
                {
                    return View("Error", new String[] { "This property can't be activated until since it's not inactive" });

                }

                //update the scalar properties
                dbProperty.PropertyStatus = PropertyStatusEnum.Active;

                //save changes
                _context.Update(dbProperty);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this review", ex.Message });
            }


            // get all properties for the logged in host
            var hostPropsQuery = _context.Properties.Include(p => p.User).Where(p => p.User.Email == User.Identity.Name);

            // yassify the query into a list
            List<Property> hostProps = hostPropsQuery
                .Include(p => p.Reviews)
                .Include(p => p.Category)
                .ToList();

            foreach (Property property in hostProps)
            {
                property.CalcAvgRating();
            }

            ////send them back to continue the process
            return View("Index", hostProps.OrderBy(p => p.PropertyNumber));


        }




        //GET approve. view for admin to literally approve.
        [Authorize(Roles = "Host")]
        public IActionResult Deactivate(int id)
        {

            if (id == null)
            {

                return View("Error", new String[] { "PropertyID not specified - which property do you want to deactivate?" });
            }


            //DEACTIVATE
            try
            {
                //find the existing prop in the database
                Property dbProperty = _context.Properties.Include(r => r.Category)
                                                            .Include(r => r.Reviews)
                                                            .Include(r => r.User)
                                                            .FirstOrDefault(r => r.PropertyID == id);
                if (dbProperty.User.Email != User.Identity.Name)
                {
                    return View("Error", new String[] { "This isn't your property to activate/deactivate" });

                }


                if (dbProperty.AdminReview != AdminApprovalEnum.Approved)
                {
                    return View("Error", new String[] { "This property can't be deactivated since it's not approved" });

                }

                if (dbProperty.PropertyStatus != PropertyStatusEnum.Active)
                {
                    return View("Error", new String[] { "This property can't be activated until since it's not active" });

                }

                //update the scalar properties
                dbProperty.PropertyStatus = PropertyStatusEnum.Inactive;

                //save changes
                _context.Update(dbProperty);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this review", ex.Message });
            }


            // get all properties for the logged in host
            var hostPropsQuery = _context.Properties.Where(p => p.User.Email == User.Identity.Name);

            // yassify the query into a list
            List<Property> hostProps = hostPropsQuery
                .Include(p => p.Reviews)
                .Include(p => p.Category)
                .ToList();

            foreach (Property property in hostProps)
            {
                property.CalcAvgRating();
            }

            ////send them back to continue the process
            return View("Index", hostProps.OrderBy(p => p.PropertyNumber));


        }

















        //GET Detailed Search
        public ActionResult DetailedSearch()
        {
            //Populate view bag with list of months
            ViewBag.AllCategories = GetAllCategoriesSearch();

            //Set default properties
            PropertySearchViewModel psvm = new PropertySearchViewModel(); 
            psvm.SelectedCategory = 0;
            psvm.SelectedCheckInDate = null;
            psvm.SelectedCheckOutDate = null;

            return View(psvm);
        }



        public IActionResult DisplaySearchResults(PropertySearchViewModel psvm)
        {
            var query = from b in _context.Properties select b; //set up intial query

            query = query.Include(b => b.Category)
                        .Include(b => b.Reviews)
                        .Include(b => b.Reservations);

            List<Reservation> resList = _context.Reservations
                .Include(r => r.Property)
                .ToList();
            List<int> TakeList = new List<int>();
            List<int> RemoveList = new List<int>();

            if (psvm.SelectedCheckOutDate == null && psvm.SelectedCheckInDate != null)
            {
                return View("Error", new String[] { "You must specify both Check In and Check Out Dates" });
            }

            if (psvm.SelectedCheckOutDate != null && psvm.SelectedCheckInDate == null)
            {
                return View("Error", new String[] { "You must specify both Check In and Check Out Dates" });
            }

            //search by DATE
            //query = query.Where(b => (psvm.SelectedCheckInDate >= b.CheckInDay && psvm.SelectedCheckInDate <= b.CheckOutDay) == true || (psvm.SelectedCheckOutDate >= b.CheckInDay && psvm.SelectedCheckOutDate <= b.CheckOutDay) == true || (b.CheckInDay >= psvm.SelectedCheckInDate && b.CheckInDay <= psvm.SelectedCheckOutDate) == true);
            if (psvm.SelectedCheckInDate != null && psvm.SelectedCheckOutDate != null)
            {
                // iterate through all reservations in the DB
                foreach (Reservation res in resList)
                {
                    // Detemine if there is an overlap between user selected dates and the date ranges of the reservations
                    // if the overlap returns as false => add the propertyID to the TakeList
                    if (((psvm.SelectedCheckInDate > res.CheckInDate && psvm.SelectedCheckInDate < res.CheckOutDate) || (psvm.SelectedCheckOutDate > res.CheckInDate && psvm.SelectedCheckOutDate <= res.CheckOutDate) || (res.CheckInDate >= psvm.SelectedCheckInDate && res.CheckOutDate <= psvm.SelectedCheckOutDate)) == false)
                    {
                        // save the property id to add
                        Int32 IdToAdd = res.Property.PropertyID;

                        // if the id is not already in the list, then do not add it to the TakeList
                        if (TakeList.Contains(IdToAdd) == false)
                        {
                            TakeList.Add(IdToAdd);
                        }
                    }
                    // route if the reservation already on the property
                    else
                    {
                        // save the property ID
                        Int32 IdToRemove = res.Property.PropertyID;

                        // remove the property ID from the list since it is no longer compatible
                        RemoveList.Add(IdToRemove);
                    }

                    // if the ID is in the remove list then remove all instances of it from the add list
                    foreach (Int32 id in RemoveList)
                    {
                        if (TakeList.Contains(id))
                        {
                            // remove all instances of the property ID from the take list
                            TakeList.RemoveAll(i => i == id);
                        }
                    }

                    // if a property has no reservation
                    foreach (Property prop in _context.Properties.Include(p => p.Reservations).ToList())
                    {
                        if (prop.Reservations.Count() == 0 && TakeList.Contains(prop.PropertyID) == false)
                        {
                            TakeList.Add(prop.PropertyID);
                        }
                    }
                }

                // limit the query to only take the properties that have in ID in the TakeList
                query = query.Where(p => TakeList.Contains(p.PropertyID));
            }

            //search by CITY
            if (psvm.SelectedCity != null && psvm.SelectedCity != "") //if user entered something THEN execute searching in db
            {
                query = query.Where(b => b.City.Contains(psvm.SelectedCity)); 
            }

            //search by ADDRESS
            if (psvm.SelectedAddress != null && psvm.SelectedAddress != "") //if user entered something THEN execute searching in db
            {
                query = query.Where(b => b.PropertyAddress.Contains(psvm.SelectedAddress));
            }


            //search by STATE
            if (psvm.SelectedState != null && psvm.SelectedState != "") //if user entered something THEN execute searching in db
            {
                query = query.Where(b => b.State.Contains(psvm.SelectedState));
            }


            //search by CATEGORY
            if (psvm.SelectedCategory != 0) //ie, if it doesn't say "All genres" which has ID of 0...
            {

                query = query.Where(b => b.Category.CategoryID == psvm.SelectedCategory); //use genre table and then genre field. no need to use g.GenreID because tables are joined!
            }



            //Search by WEEKDAY PRICE
            if (psvm.SelectedWeekdayPrice != 0)
            {
                if (psvm.WeekdaySelectedType == SearchType.GreaterThan)
                {
                    query = query.Where(b => b.WeekdayPrice >= psvm.SelectedWeekdayPrice);
                }
                else
                {
                    query = query.Where(b => b.WeekdayPrice <= psvm.SelectedWeekdayPrice);

                }

            }

            //Search by WEEKEND PRICE
            if (psvm.SelectedWeekendPrice != 0)
            {
                if (psvm.WeekendSelectedType == SearchType.GreaterThan)
                {
                    query = query.Where(b => b.WeekendPrice >= psvm.SelectedWeekendPrice);
                }
                else
                {
                    query = query.Where(b => b.WeekendPrice <= psvm.SelectedWeekendPrice);

                }

            }

            //search by BEDROOMS
            if (psvm.SelectedBedrooms != 0) 
            {

                if (psvm.BedroomsSelectedType == SearchType.GreaterThan)
                {
                    query = query.Where(b => b.NumberOfBedrooms >= psvm.SelectedBedrooms);
                }
                else
                {
                    query = query.Where(b => b.NumberOfBedrooms <= psvm.SelectedBedrooms);

                }
            }

            //search by BATHROOMS
            if (psvm.SelectedBathrooms != 0)
            {

                if (psvm.BathroomsSelectedType == SearchType.GreaterThan)
                {
                    query = query.Where(b => b.NumberOfBathrooms >= psvm.SelectedBathrooms);
                }
                else
                {
                    query = query.Where(b => b.NumberOfBathrooms <= psvm.SelectedBathrooms);

                }
            }

            //search by GUESTS
            if (psvm.SelectedGuests != 0)
            {

                if (psvm.GuestsNumberSelectedType == SearchType.GreaterThan)
                {
                    query = query.Where(b => b.GuestLimit >= psvm.SelectedGuests);
                }
                else
                {
                    query = query.Where(b => b.GuestLimit <= psvm.SelectedGuests);

                }
            }

            //search by RATING

            if (psvm.GuestRatingSelectedType == SearchType.GreaterThan)
            {
                query = query.Where(b => b.GuestRating >= psvm.SelectedGuestRating);
            }
            else
            {
                query = query.Where(b => b.GuestRating <= psvm.SelectedGuestRating);

            }

            //search by PARKING
            if (psvm.SelectedFreeParking == true)
            {

                query = query.Where(b => b.FreeParking == true);
            }

            //search by PETS ALLOWED
            if (psvm.SelectedPetsAllowed == true)
            {

                query = query.Where(b => b.PetsAllowed == true);
            }



            List<Property> SelectedProperties = query.Include(b => b.Category)
                                                    .Include(b => b.Reviews)
                                                    .Where(b => b.PropertyStatus == PropertyStatusEnum.Active)
                                                    .ToList();

            //calc avg rating for each property in the selected properties list
            foreach (Property property in SelectedProperties)
            {
                property.CalcAvgRating();
            }

            //Populate the view bag with a count of all books      
            ViewBag.AllProperties = _context.Properties.Where(p => p.PropertyStatus == PropertyStatusEnum.Active)
                                                       .Count();

            //Populate the view bag with a count of selected books
            ViewBag.SelectedProperties = SelectedProperties.Count();

            return View("SearchResults", SelectedProperties);
        }


        // GET: Properties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a property to edit!" });
            }

            //find the property in the database
            Property property = await _context.Properties.Include(c => c.Category).Include(c => c.User)
                                           .FirstOrDefaultAsync(c => c.PropertyID == id);

            //check that this property belongs to the person logged in
            if (property.User.UserName != User.Identity.Name)
            {
                return View("Error", new string[] { "You're not the host so you can't edit this property!" });

            }

            //if the course does not exist in the database, then show the user
            //an error message
            if (property == null)
            {
                return View("Error", new string[] { "This property was not found!" });
            }

            //ViewBag.AllCategories = GetAllCategories(property);


            return View(property);
        }

        // POST: Properties/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PropertyID,PropertyNumber,Zip, City,State, PropertyAddress, WeekdayPrice,WeekendPrice,DiscountRate,DaysToDiscount,HostEmail,CleaningFee,NumberOfBedrooms,NumberOfBathrooms,GuestRating,PetsAllowed,FreeParking,GuestLimit,PropertyStatus")] Property property)
        {

            //this is a security check to see if the user is trying to modify
            //a different record.  Show an error message
            if (id != property.PropertyID)
            {
                return View("Error", new string[] { "Please try again!" });
            }

            //if (ModelState.IsValid == false) //there is something wrong
            //{
            //    //ViewBag.AllCategories = GetAllCategories(property);
            //    return View(property);
            //}

            try
            {
                //find db object
                Property dbProperty = _context.Properties
                        .Include(c => c.Category)
                        .Include(c => c.User)
                        .FirstOrDefault(c => c.PropertyID == property.PropertyID);


                //update the property's scalar properties
                dbProperty.WeekdayPrice = property.WeekdayPrice;
                dbProperty.WeekendPrice = property.WeekendPrice;
                dbProperty.CleaningFee = property.CleaningFee;
                dbProperty.DiscountRate = property.DiscountRate;
                dbProperty.DaysToDiscount = property.DaysToDiscount;
         
            //save the changes
            _context.Properties.Update(dbProperty);
            _context.SaveChanges();


            }
            catch (Exception ex)
            {
                return View("Error", new string[] { "There was an error editing this property.", ex.Message });
            }

            return RedirectToAction(nameof(Index));
           
        }

        [Authorize(Roles = "Host")]
        public IActionResult HostProperties()
        {
            // get all properties for the logged in host
            var hostPropsQuery = _context.Properties.Where(p => p.User.Email == User.Identity.Name);

            // yassify the query into a list
            List<Property> hostProps = hostPropsQuery
                .Include(p => p.Reviews)
                .Include(p => p.Category)
                .ToList();

            // calculate each properties rating
            foreach (Property property in hostProps)
            {
                property.CalcAvgRating();
            }

            // send the yassified query to the properties index page to display all the queries
            return View("Index", hostProps.OrderBy(p => p.PropertyNumber));
        }


        //// GET: Properties/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var @property = await _context.Properties
        //        .FirstOrDefaultAsync(m => m.PropertyID == id);
        //    if (@property == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(@property);
        //}

        //// POST: Properties/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var @property = await _context.Properties.FindAsync(id);
        //    _context.Properties.Remove(@property);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool PropertyExists(int id)
        {
            return _context.Properties.Any(e => e.PropertyID == id);
        }
    }
}
