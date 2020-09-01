using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentalPlatform.Data.Migrations
{
    public partial class CartDeliveryDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PreferredDeliveryDate",
                table: "Cart",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PreferredDeliveryDate",
                table: "Cart");
        }
    }
}
