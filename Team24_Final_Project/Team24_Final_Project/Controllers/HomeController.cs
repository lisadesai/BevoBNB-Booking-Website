using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Team24_Final_Project.DAL;
using Team24_Final_Project.Models;
using Team24_Final_Project.Models.ViewModels;

namespace Team24_Final_Project.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        //Create the constructor so that we get an instance of AppDbContext
        public HomeController(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }


    }
}
