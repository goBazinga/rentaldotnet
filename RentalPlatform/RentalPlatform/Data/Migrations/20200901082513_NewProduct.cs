using Microsoft.EntityFrameworkCore.Migrations;

namespace RentalPlatform.Data.Migrations
{
    public partial class NewProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageURL", "Name", "Price", "Quantity", "QuantityAvailable" },
                values: new object[] { 2, null, "https://assets.kogan.com/files/product/2020/ELBROFCHRBA/ELBROFCHRBA_4.jpg", "W-Chair", 25.00m, 50, 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
