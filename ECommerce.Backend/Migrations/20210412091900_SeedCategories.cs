using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Backend.Migrations
{
    public partial class SeedCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Switch", "The Nintendo Switch (known as the NX in development) is a eighth generation home video game console released by Nintendo, and its seventh major home game console as the successor to the Wii U." },
                    { 2, "PC", "Stands for 'Personal computer'. PCs are what most of us use on a daily basis for work or personal use. A typical PC includes a system unit, monitor, keyboard, and mouse." },
                    { 3, "PlayStation", "PS is a video game brand that consists of five home video game consoles, as well as a media center, an online service, a line of controllers, two handhelds and a phone, as well as multiple magazines." },
                    { 4, "Xbox", "The brand consists of five video game consoles, as well as applications (games), streaming services, an online service by the name of Xbox Live, and the development arm by the name of Xbox Game Studios." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
