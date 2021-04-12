using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Backend.Migrations
{
    public partial class SeedProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Images", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 17, 2, 0, 866, DateTimeKind.Local).AddTicks(695), "persona-5-scramble-strikers-switch.jpg", new DateTime(2021, 4, 12, 17, 2, 0, 867, DateTimeKind.Local).AddTicks(2011) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Images", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 16, 54, 29, 862, DateTimeKind.Local).AddTicks(5383), "/user-content/persona-5-scramble-strikers-switch.jpg", new DateTime(2021, 4, 12, 16, 54, 29, 865, DateTimeKind.Local).AddTicks(4679) });
        }
    }
}
