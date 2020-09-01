using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentalPlatform.Models;

namespace RentalPlatform.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "W-Desk",
                    Price = 50.00m,
                    Quantity = 20,
                    QuantityAvailable = 10,
                    ImageURL = "https://www.schiavello.com/__data/assets/image/0029/8777/varieties/desktop.jpg"
                }
            );

            base.OnModelCreating(builder);
        }
    }
}
