using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Backend.Migrations
{
    public partial class SeedBrandProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Amazon" },
                    { 2, "Steam" },
                    { 3, "Epic" },
                    { 4, "Sony" },
                    { 5, "Xbox" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "CreatedDate", "Description", "Images", "Price", "ProductName", "UnitsInStock", "UnitsOnOrder", "UpdatedDate" },
                values: new object[] { 1, 1, 1, new DateTime(2021, 4, 12, 16, 54, 29, 862, DateTimeKind.Local).AddTicks(5383), "Join the Phantom Thieves and strike back against the corruption overtaking cities across Japan. A summer vacation with close friends takes a sudden turn as a distorted reality emerges; reveal the truth and redeem the hearts of those imprisoned at the center of the crisis! Jump into the stylish world of Persona in an all-new story Dynamically control your team during explosive action combat Battle across Japan in an epic road trip Key Features Include: /nExperience the world of Persona 5 Strikers on PC in Full HD, supports up to 4K /nSteam Achievements and Trading Cards /nChoose between Japanese and English VO /nFull keyboard and mouse adaptation", "/user-content/persona-5-scramble-strikers-switch.jpg", 59.99m, "Persona 5 - Scramble Striker", 10, 0, new DateTime(2021, 4, 12, 16, 54, 29, 865, DateTimeKind.Local).AddTicks(4679) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
