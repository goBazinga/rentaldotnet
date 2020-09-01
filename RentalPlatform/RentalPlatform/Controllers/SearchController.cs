using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentalPlatform.Data;

namespace RentalPlatform.Controllers
{
    public class SearchController : Controller
    {
        public ApplicationDbContext Context { get; set; }

        public SearchController()
        {
            Context = new ApplicationDbContext();
        }

        public IActionResult Index()
        {
            var allProducts = Context.Products.ToList();

            return View();
        }
    }
}