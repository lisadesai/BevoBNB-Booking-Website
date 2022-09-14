using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team24_Final_Project.DAL;
using Team24_Final_Project.Models;

namespace Team24_Final_Project.Controllers
{
    public class AdminReportsController : Controller
    {
        private readonly AppDbContext _context;
        private DateTime startBorder = new DateTime(1900, 1, 1);
        private DateTime endBorder = new DateTime(2200, 1, 1);

        public AdminReportsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET method AdminReports/Create
        public  IActionResult Create()
        {
            AdminSearchViewModel avm = new AdminSearchViewModel();
            avm.SearchPropertyID = new int[] { 0 };
            avm.SearchCategoryID = new int[] { 0 };
            avm.SearchCheckInDay = startBorder;
            avm.SearchCheckOutDay = endBorder;
            ViewBag.AdminAllProperties = GetAllProperties();
            ViewBag.AdminAllCategories = GetAllCategories();

            return View(avm);
        }

        //POST method to display the search results
        public IActionResult DisplaySearchResults(AdminSearchViewModel avm)
        {   
            // only for hosts
            //var report = _context.Reservations
            //           .Where(r => r.Order.User.Email == User.Identity.Name);

            var report = from r in _context.Reservations select r;

            // search by properties
            if (avm.SearchPropertyID.Contains(0) == false)
            {
                report = report.Where(r => avm.SearchPropertyID.Contains(r.Property.PropertyID));
            }

            // search by categories
            if (avm.SearchCategoryID.Contains(0) == false)
            {
                report = report.Where(r => avm.SearchCategoryID.Contains(r.Property.Category.CategoryID));
            }

            // limit the date range (whether user specified or not)
            report = report.Where(r => (avm.SearchCheckInDay >= r.CheckInDate && avm.SearchCheckInDay <= r.CheckOutDate) == true || (avm.SearchCheckOutDay >= r.CheckInDate && avm.SearchCheckOutDay <= r.CheckOutDate) == true || (r.CheckInDate >= avm.SearchCheckInDay && r.CheckInDate <= avm.SearchCheckOutDay) == true);

            // include only confirmed reports (collected money)
            report = report.Where(r => r.Status == ReservationStatus.Confirmed);

            List<Reservation> resReport = report
                                        .Include(r => r.Property)
                                        .ThenInclude(r => r.Category)
                                        .ToList();

            // count total number of properties reserved
            var allProps = from r in report select r.Property.PropertyAddress;
            avm.NumberOfProperties = allProps.Distinct().Count();

            // count total number of reservations
            avm.NumberOfReservations = resReport.Count;

            avm.TotalCommissions = report.Sum(r => r.TotalStayPrice);
            avm.TotalCommissions = avm.TotalCommissions * .10m;

            avm.AverageCommission = (avm.TotalCommissions / avm.NumberOfReservations);

            return View("Index", avm);
        }

        private MultiSelectList GetAllProperties()
        {
            List<Property> propertiesList = _context.Properties.ToList();

            Property SelectNone = new Property() { PropertyID = 0, PropertyAddress = "All Properties" };
            propertiesList.Add(SelectNone);

            MultiSelectList propSelectList = new MultiSelectList(propertiesList.OrderBy(p => p.PropertyID), "PropertyID", "PropertyAddress");

            return propSelectList;
        }

        private MultiSelectList GetAllCategories()
        {
            List<Category> catList = _context.Categories.ToList();

            Category SelectNone = new Category() { CategoryID = 0, CategoryName = "All Categories" };
            catList.Add(SelectNone);

            MultiSelectList catSelectList = new MultiSelectList(catList.OrderBy(c => c.CategoryID), "CategoryID", "CategoryName");

            return catSelectList;
        }
    }
}
