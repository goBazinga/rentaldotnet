using Microsoft.EntityFrameworkCore.Migrations;

namespace RentalPlatform.Data.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "https://s3-ap-southeast-2.amazonaws.com/wc-prod-pim/JPEG_1000x1000/OTARKENDSK_D_arken_solid_timber_single_drawer_desk_white_oak.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "https://www.schiavello.com/__data/assets/image/0029/8777/varieties/desktop.jpg");
        }
    }
}
