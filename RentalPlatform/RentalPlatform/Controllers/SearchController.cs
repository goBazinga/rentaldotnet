using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RentalPlatform.Data;
using System.Security.Claims;
using RentalPlatform.Models;

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
            var userId = User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;

            Context.Cart.Add(new Models.Cart()
            {
                UserId = userId,
                Product = allProducts.First(x => x.Id == 1)
            });

            Context.SaveChanges();

            return View();
        }
    }
}