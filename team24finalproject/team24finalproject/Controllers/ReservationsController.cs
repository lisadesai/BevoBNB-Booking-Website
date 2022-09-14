using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Team24_Final_Project.Utilities;
using Team24_Final_Project.DAL;
using Team24_Final_Project.Models;
using Microsoft.AspNetCore.Authorization;

namespace Team24_Final_Project.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly AppDbContext _context;

        public ReservationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reservations
        public async Task<IActionResult> Index(int? orderID)
        {
            if (orderID == null)
            {
                return View("Error", new String[] { "Please specify an order to view." });
            }

            List<Reservation> res = await _context.Reservations
                .Include(r => r.Property)
                .Where(r => r.Order.OrderID == orderID)
                .ToListAsync();

            // manually set the order navigationally property 
            foreach (Reservation reservation in res)
            {
                reservation.Order = _context.Orders.Find(orderID);
            }

            return View(res);
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(m => m.ReservationID == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Booking a reservation from the property/index page
        [Authorize(Roles = "Host, Customer, Admin")]
        public async Task<IActionResult> Book(int id)
        {
            Reservation res = new Reservation();

            // get order from the db
            Order dbOrder = _context.Orders.FirstOrDefault(o => o.User.Email == User.Identity.Name && o.Status == OrderStatus.Pending);

            // check if there is an order
            // if there is an order then put the reservation on that order
            if (dbOrder != null)
            {
                res.Order = dbOrder;
            }
            else
            {
                // create a new order
                Order newOrder = new Order()
                {
                    OrderNumber = Utilities.GenerateOrderNumber.GetNextOrderNumber(_context),
                    Status = OrderStatus.Pending
                };
                newOrder.User = _context.Users.FirstOrDefault(u => u.Email == User.Identity.Name);

                _context.Add(newOrder);
                await _context.SaveChangesAsync();

                res.Order = newOrder;
            }

            // now find the property associated with the route value
            Property dbProperty = _context.Properties.Find(id);

            // match the reservation with the property
            res.Property = dbProperty;

            //_context.Add(res);
            await _context.SaveChangesAsync();

            // return the View to book this mf
            return View(res);
        }

        // POST: booking a property through the property/index view
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Book(Reservation reservation)
        {
            reservation.Order = _context.Orders.Find(reservation.Order.OrderID);
            reservation.Property = _context.Properties.Find(reservation.Property.PropertyID);

            if (reservation.CheckInDate > reservation.CheckOutDate)
            {
                return View("Error", new String[] { "Nice try. Now you have to start all over. " });
            }

            // find a count of all the conflicting dates
            var resCount = _context.Reservations
                .Where(r => r.Property.PropertyID == reservation.Property.PropertyID)
                .Where(r => r.Status != ReservationStatus.Cancelled)
                .Where(r => (reservation.CheckInDate >= r.CheckInDate && reservation.CheckInDate < r.CheckOutDate) || (reservation.CheckOutDate > r.CheckInDate && reservation.CheckOutDate <= r.CheckOutDate) || (r.CheckInDate >= reservation.CheckInDate && r.CheckOutDate <= reservation.CheckOutDate))
                .Count();

            // return error if there are any conflicts
            if (resCount > 0)
            {
                return View("ReservationError", reservation);
            }

            // check for no overlapping reservations on the same order
            var internalResCount = _context.Reservations
                    .Where(r => r.Order.OrderID == reservation.Order.OrderID)
                    .Where(r => r.Status != ReservationStatus.Cancelled)
                    .Where(r => (reservation.CheckInDate >= r.CheckInDate && reservation.CheckInDate < r.CheckOutDate) || (reservation.CheckOutDate > r.CheckInDate && reservation.CheckOutDate <= r.CheckOutDate) || (r.CheckInDate >= reservation.CheckInDate && r.CheckOutDate <= reservation.CheckOutDate))
                    .Count();

            if (internalResCount > 0)
            {
                return View("ReservationError", reservation);
            }

            // initiate total stay price
            reservation.TotalStayPrice = 0m;

            foreach (DateTime day in Utilities.DateLoop.EachDay(reservation.CheckInDate, reservation.CheckOutDate.AddDays(-1)))
            {
                if (day.DayOfWeek == DayOfWeek.Friday || day.DayOfWeek == DayOfWeek.Saturday)
                {
                    reservation.TotalStayPrice = reservation.TotalStayPrice + reservation.Property.WeekendPrice;
                }
                else
                {
                    reservation.TotalStayPrice = reservation.TotalStayPrice + reservation.Property.WeekdayPrice;
                }
            }

            // set the weekday cost of the reservation to the current weekday cost of the property
            reservation.WeekdayPrice = reservation.Property.WeekdayPrice;
            reservation.WeekendPrice = reservation.Property.WeekendPrice;
            reservation.CleaningFee = reservation.Property.CleaningFee;

            if ((reservation.CheckOutDate - reservation.CheckInDate).Days >= reservation.Property.DaysToDiscount)
            {
                reservation.DiscountRate = reservation.Property.DiscountRate;
            }
            else
            {
                reservation.DiscountRate = 0m;
            }


            if (reservation.NumberOfGuests > reservation.Property.GuestLimit)
            {
                return View("Error", new String[] { "Property guest limit exceeded. Please book fewer guests or select a different property" });
            }

            // put that shit into the DB
            _context.Update(reservation);
            await _context.SaveChangesAsync();

            // go back to the Orders/Details View
            return RedirectToAction("Details", "Orders", new { id = reservation.Order.OrderID });
        }

        // GET: Reservations/Create
        public IActionResult Create(int orderID)
        {
            Reservation r = new Reservation();

            // find order associated with the orderID
            Order dbOrder = _context.Orders.Find(orderID);

            // set the new reservation to the order that was just found
            r.Order = dbOrder;

            // populate the viewbag with all the existing properties
            ViewBag.AllProperties = GetAllProperties();

            return View(r);
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Order,ReservationID,CheckInDate,CheckOutDate,NumberOfGuests")] Reservation reservation, int SelectedProperty)
        {
            if (ModelState.IsValid == false)
            {
                ViewBag.AllProperties = GetAllProperties();
                return View(reservation);
            }

            if (reservation.CheckInDate > reservation.CheckOutDate)
            {
                return View("Error", new String[] { "Nice try. Now you have to start all over. " });
            }

            // find the property from the passed propertyID
            Property dbProperty = _context.Properties.Find(SelectedProperty);

            // set reservation property **property** to the one found in the db above
            reservation.Property = dbProperty;

            // find a count of all the conflicting dates
            var resCount = _context.Reservations
                .Where(r => r.Property.PropertyID == SelectedProperty)
                .Where(r => (r.CheckInDate <= reservation.CheckInDate && r.CheckOutDate > reservation.CheckInDate) || (r.CheckInDate <= reservation.CheckOutDate && r.CheckOutDate > reservation.CheckOutDate) || (r.CheckInDate >= reservation.CheckInDate && r.CheckInDate < reservation.CheckOutDate))
                .Where(r => r.Status != ReservationStatus.Cancelled)
                .Count();

            // return error if there are any conflicts
            if (resCount > 0)
            {
                return View("ReservationError", reservation);
            }

            // find the order associated with the reservation argument passed above using the orderID property of the reservation
            Order dbOrder = _context.Orders.Find(reservation.Order.OrderID);

            // set the reservation Order property to the one from the DB
            reservation.Order = dbOrder;

            // check for no overlapping reservations on the same order
            var internalResCount = _context.Reservations
                    .Where(r => r.Order.OrderID == dbOrder.OrderID)
                    .Where(r => (r.CheckInDate <= reservation.CheckInDate && r.CheckOutDate > reservation.CheckInDate) || (r.CheckInDate <= reservation.CheckOutDate && r.CheckOutDate > reservation.CheckOutDate) || (r.CheckInDate >= reservation.CheckInDate && r.CheckInDate < reservation.CheckOutDate))
                    .Count();

            if (internalResCount > 0)
            {
                return View("ReservationError", reservation);
            }

            // initiate total stay price
            reservation.TotalStayPrice = 0m;

            foreach (DateTime day in Utilities.DateLoop.EachDay(reservation.CheckInDate, reservation.CheckOutDate.AddDays(-1)))
            {
                if (day.DayOfWeek == DayOfWeek.Friday || day.DayOfWeek == DayOfWeek.Saturday)
                {
                    reservation.TotalStayPrice = reservation.TotalStayPrice + dbProperty.WeekendPrice;
                }
                else
                {
                    reservation.TotalStayPrice = reservation.TotalStayPrice + dbProperty.WeekdayPrice;
                }
            }

            // set the weekday cost of the reservation to the current weekday cost of the property
            reservation.WeekdayPrice = dbProperty.WeekdayPrice;
            reservation.WeekendPrice = dbProperty.WeekendPrice;
            reservation.CleaningFee = dbProperty.CleaningFee;
            if ((reservation.CheckOutDate - reservation.CheckInDate).Days >= dbProperty.DaysToDiscount)
            {
                reservation.DiscountRate = dbProperty.DiscountRate;
            }
            else
            {
                reservation.DiscountRate = 0m;
            }
            

            if (reservation.NumberOfGuests > dbProperty.GuestLimit)
            {
                return View("Error", new String[] { "Property guest limit exceeded. Please book fewer guests or select a different property" });
            }

            // put that shit into the DB
            _context.Add(reservation);
            await _context.SaveChangesAsync();

            // go back to the Orders/Details View
            return RedirectToAction("Details", "Orders", new { id = reservation.Order.OrderID });
        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify an order detail to edit!" });
            }

            Reservation reservation = await _context.Reservations
                .Include(r => r.Property)
                .Include(r => r.Order)
                .FirstOrDefaultAsync(r => r.ReservationID == id);

            if (reservation == null)
            {
                return View("Error", new String[] { "This order detail was not found" });
            }
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReservationID,Status")] Reservation reservation)
        {
            if (id != reservation.ReservationID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }

            if (ModelState.IsValid == false)
            {
                return View(reservation);
            }

            Reservation res;

            try
            {
                res = _context.Reservations
                    .Include(r => r.Order)
                    .Include(r => r.Property)
                    .FirstOrDefault(r => r.ReservationID == reservation.ReservationID);

                res.WeekdayPrice = reservation.WeekdayPrice;
                res.WeekendPrice = reservation.WeekendPrice;
                res.Status = reservation.Status;

                // save the changes
                _context.Update(res);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record" });
            }

            // go back to the Orders/Details view
            return RedirectToAction("Details:", "Orders", new { id = res.Order.OrderID });
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a registration detail to delete!" });
            }

            Reservation reservation = await _context.Reservations
                .Include(r => r.Order)
                .FirstOrDefaultAsync(m => m.ReservationID == id);

            if (reservation == null)
            {
                return View("Error", new String[] { "This registration detail was not in the database!" });
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // find the reservation being deleted
            Reservation reservation = await _context.Reservations
                .Include(r => r.Order)
                .FirstOrDefaultAsync(r => r.ReservationID == id);

            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();

            // go back to the Orders/Details page
            return RedirectToAction("Details", "Orders", new { id = reservation.Order.OrderID });
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.ReservationID == id);
        }

        private SelectList GetAllProperties()
        {
            List<Property> allProps = _context.Properties.ToList();

            // create the selectlist
            SelectList slAllProps = new SelectList(allProps, nameof(Property.PropertyID), nameof(Property.PropertyAddress));

            return slAllProps;
        }

        public IActionResult CustomerReservations()
        {
            // get all reservations for a specific customer on any order
            var query = _context.Reservations.Where(r => r.Order.User.Email == User.Identity.Name);

            // yassify the list
            List<Reservation> custRes = query
                                    .Include(q => q.Order)
                                    .ThenInclude(q => q.User)
                                    .Include(q => q.Property)
                                    .ToList();

            // display the results on the Reservations Index View
            return View("Index", custRes);
        }

        public async Task<IActionResult> Cancel(int? id)
        {
            // find the reservation specified
            //Reservation reservation = _context.Reservations.Find(id);


            // find the reservation specified
            Reservation reservation = _context.Reservations.Include(r => r.Order)
                                                            .ThenInclude(r => r.User)
                                                            .Include(r => r.Property)
                                                            .FirstOrDefault(r => r.ReservationID == id);


            // validation
            if (reservation.Status == ReservationStatus.Cancelled)
            {
                return View("Error", new String[] { "This is answer is already canceled. Now you have to start all over." });
            }

            // more validation
            if (reservation.CancelByDate >= DateTime.Today)
            {
                // change the status of the reservation
                reservation.Status = ReservationStatus.Cancelled;
            }
            else
            {
                return View("Error", new String[] { "It is too late to cancel this reservation. Cancellations must happen 24 hours prior to check in day." });
            }


            ////SEND EMAIL
            string subject = " Your order " + reservation.Order.OrderNumber + " is cancelled";

            string body = "We're sorry to see you go. Come back soon!";

            SendMail.EmailMessaging.SendEmail(reservation.Order.User.Email, subject, body);

            // update the database
            _context.Update(reservation);
            await _context.SaveChangesAsync();

            return View(reservation);
        }
    }
}
