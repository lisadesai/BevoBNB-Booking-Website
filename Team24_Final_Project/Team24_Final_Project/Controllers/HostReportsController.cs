using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team24_Final_Project.DAL;
using Team24_Final_Project.Models;

namespace Team24_Final_Project.Controllers
{
    public class HostReportsController : Controller
    {
        private readonly AppDbContext _context;
        private DateTime startBorder = new DateTime(1900, 1, 1);
        private DateTime endBorder = new DateTime(2200, 1, 1);

        public HostReportsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            HostSearchViewModel hvm = new HostSearchViewModel();
            hvm.SearchPropertyID = new int[] { 0 };
            hvm.SearchCategoryID = new int[] { 0 };
            hvm.SearchCheckInDay = startBorder;
            hvm.SearchCheckOutDay = endBorder;
            ViewBag.HostAllProperties = GetAllProperties();
            ViewBag.HostAllCategories = GetAllCategories();

            return View(hvm);
        }

        public IActionResult DisplaySearchResults(HostSearchViewModel hvm)
        {
            // get all reservations associated with current host
            var report = _context.Reservations.Where(r => r.Property.User.Email == User.Identity.Name);

            // search by user properties
            if (hvm.SearchPropertyID.Contains(0) == false)
            { 
                report = report.Where(r => hvm.SearchPropertyID.Contains(r.Property.PropertyID));
            }

            // search by categories 
            //TODO: if possible -- limit to only inlcude categories that apply to host owned properties
            if (hvm.SearchCategoryID.Contains(0) == false)
            {
                report = report.Where(r => hvm.SearchCategoryID.Contains(r.Property.Category.CategoryID));
            }
            
            if (report.Count() == 0)
            {
                return View("Error", new String[] { "You do not have a property that is in this category. Nice try though." });
            }

            // limit the date range
            report = report.Where(r => (hvm.SearchCheckInDay >= r.CheckInDate && hvm.SearchCheckInDay <= r.CheckOutDate) == true || (hvm.SearchCheckOutDay >= r.CheckInDate && hvm.SearchCheckOutDay <= r.CheckOutDate) == true || (r.CheckInDate >= hvm.SearchCheckInDay && r.CheckInDate <= hvm.SearchCheckOutDay) == true);

            // include only confirmed reports
            report = report.Where(r => r.Status == ReservationStatus.Confirmed);

            ViewBag.HostReservations = report.Count();

            List<Reservation> hostResReport = report
                                        .Include(r => r.Property)
                                        .ThenInclude(r => r.Category)
                                        .ToList();

            // remove duplicate properties
            // list to hold property ids
            List<int> holdIDs = new List<int>();
            foreach (Reservation res in hostResReport)
            {
                if (holdIDs.Contains(res.Property.PropertyID) == false)
                {
                    holdIDs.Add(res.Property.PropertyID);
                }
            }

            List<Property> finalReport = new List<Property>();
            foreach (int id in holdIDs)
            {
                Property pp = _context.Properties.Find(id);
                finalReport.Add(pp);
            }

            return View("Index", finalReport);
        }

        private MultiSelectList GetAllProperties()
        {
            var hostProps = _context.Properties.Where(p => p.User.Email == User.Identity.Name);

            List<Property> propertiesList = hostProps.ToList();

            Property SelectNone = new Property() { PropertyID = 0, PropertyAddress = "All Properties" };
            propertiesList.Add(SelectNone);

            MultiSelectList propSelectList = new MultiSelectList(propertiesList.OrderBy(p => p.PropertyID), "PropertyID", "PropertyAddress");

            return propSelectList;
        }

        private MultiSelectList GetAllCategories()
        {
            var hostCats = _context.Categories;

            List < Category > catList = hostCats.ToList();

            Category SelectNone = new Category() { CategoryID = 0, CategoryName = "All Categories" };
            catList.Add(SelectNone);

            MultiSelectList catSelectList = new MultiSelectList(catList.OrderBy(c => c.CategoryID), "CategoryID", "CategoryName");

            return catSelectList;
        }
    }
}