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
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        [Authorize(Roles = "Host, Customer, Admin")]
        public async Task<IActionResult> Index()
        {
            List<Order> ordersList;

            ordersList = await _context.Orders
                        .Include(o => o.Reservations)
                        .Include(o => o.User)
                        .Where(o => o.User.Email == User.Identity.Name)
                        .ToListAsync();

            foreach (Order order in ordersList)
            {
                order.CalcSubtotal();

                _context.Update(order);
                await _context.SaveChangesAsync();
            }

            return View(ordersList);
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify an order to view!" });
            }

            Order order = await _context.Orders
                .Include(o => o.Reservations)
                .ThenInclude(o => o.Property)
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderID == id);

            order.CalcSubtotal();

            _context.Update(order);
            await _context.SaveChangesAsync();

            if (order == null)
            {
                return View("Error", new String[] { "This order was not found in the database" });
            }

            // security check to ensure that the order actually belongs to the customer
            if (User.IsInRole("Customer")==false || order.User.Email != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your order you clown." });
            }

            return View(order);
        }

        // GET: Orders/Create
        [Authorize(Roles = "Host, Customer, Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,DateBooked,CancelByDate,NumberOfGuests,Subtotal,Total,DiscountAmount")] Order order)
        {
            order.OrderNumber = Utilities.GenerateOrderNumber.GetNextOrderNumber(_context);

            // do something with the order date shit

            order.User = await _context.Users.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);

            if (ModelState.IsValid == false)
            {
                return View(order);
            }

            _context.Add(order);
            await _context.SaveChangesAsync();

            // route value to the Reservation/Create View
            return RedirectToAction("Create", "Reservations", new { orderID = order.OrderID });
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify an order to view" });
            }

            Order order = await _context.Orders
                .Include(o => o.Reservations)
                .ThenInclude(o => o.Property)
                .Include(o => o.User)
                .FirstOrDefaultAsync(o => o.OrderID == id);

            if (order == null)
            {
                return View("Error", new String[] { "This order was not found in the database" });
            }

            //registration does not belong to this user
            if (User.IsInRole("Customer")==false || order.User.Email != User.Identity.Name)
            {
                return View("Error", new String[] { "You are not authorized to edit this order you clown!" });
            }

            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,DateBooked,CancelByDate,NumberOfGuests,Subtotal,Total,DiscountAmount")] Order order)
        {
            if (id != order.OrderID)
            {
                return View("Error", new String[] { "Issue editing this order. Try again." });
            }

            if (ModelState.IsValid == false)
            {
                return View(order);
            }

            try
            {
                Order dbOrder = _context.Orders.Find(order.OrderID);

                // editable shit if there is any -- update it dbOrder.blah = order.blah
                order.CalcSubtotal();
                _context.Update(dbOrder);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this registration", ex.Message });
            }

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Checkout(int? id)
        {

            if (id == null)
            {
                return View("Error", new String[] { "Please create an order to proceed with checkout" });
            }

            Order order = await _context.Orders
                .Include(o => o.Reservations)
                .ThenInclude(o => o.Property)
                .Include(o => o.User)
                .FirstOrDefaultAsync(o => o.OrderID == id);

            if (order == null)
            {
                return View("Error", new String[] { "This order was not found in the database. Try again"});
            }

            var resCount = _context.Orders
                        .Include(o => o.Reservations)
                        .Where(o => o.OrderID == id)
                        .Count();

            if (resCount < 1)
            {
                return View("Error", new String[] { "You must have at least one reservation in cart to proceed to checkout." });
            }

            return View(order);
        }

        public async Task<IActionResult> Confirm(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "How did you get to this page?? At this point it's your fault for trying to break the website" });
            }

            Order order = await _context.Orders
                .Include(o => o.Reservations)
                .ThenInclude(o => o.Property)
                .Include(o => o.User)
                .FirstOrDefaultAsync(o => o.OrderID == id);

            if (order == null)
            {
                return View("Error", new String[] { "You do not have an order so why are you trying to come here????" });
            }

            // mark the order as confirmed
            order.Status = OrderStatus.Confirmed;

            // mark all reservations as confirmed on the order
            foreach (Reservation res in order.Reservations)
            {
                if (res.Status == ReservationStatus.Pending)
                {
                    res.Status = ReservationStatus.Confirmed;
                }
            }

            //SEND EMAIL
            string subject = " Your order is confirmed!";

            string body = "Thanks for booking with BevoBnB!";

            SendMail.EmailMessaging.SendEmail(order.User.Email, subject, body);



            //update db
            _context.Update(order);
            await _context.SaveChangesAsync();

            return View(order);
        }
        // 
        // PROBABLY NEED TO DELETE -- ONLY CANCEL RESERVATIONS
        //
        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderID == id);
        }
    }
}
