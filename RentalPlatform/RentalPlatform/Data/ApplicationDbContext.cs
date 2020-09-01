using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RentalPlatform.Models;

namespace RentalPlatform.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Cart { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var product = new Product()
            {
                Id = 1,
                Name = "W-Desk",
                Price = 50.00m,
                Quantity = 20,
                QuantityAvailable = 10,
                ImageURL = "https://www.schiavello.com/__data/assets/image/0029/8777/varieties/desktop.jpg"
            };

            builder.Entity<Product>().HasData(
                product
            );

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-RentalPlatform-E95AFBAF-EAD4-463B-9A08-B8E66FA2A727;Trusted_Connection=True;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
