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
            builder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "W-Desk",
                    Price = 50.00m,
                    Quantity = 20,
                    QuantityAvailable = 10,
                    ImageURL = "https://s3-ap-southeast-2.amazonaws.com/wc-prod-pim/JPEG_1000x1000/OTARKENDSK_D_arken_solid_timber_single_drawer_desk_white_oak.jpg"
                },
                new Product()
                {
                    Id = 2,
                    Name = "W-Chair",
                    Price = 25.00m,
                    Quantity = 50,
                    QuantityAvailable = 15,
                    ImageURL = "https://assets.kogan.com/files/product/2020/ELBROFCHRBA/ELBROFCHRBA_4.jpg"
                }
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
