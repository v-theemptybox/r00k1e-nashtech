using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Backend.Migrations
{
    public partial class UpdateRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Products_ProductId",
                table: "Ratings");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 397, DateTimeKind.Local).AddTicks(4679), new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(6984), new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(6998), new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7002), new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7007), new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7011), new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7015), new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7020), new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7024), new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7028), new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7032), new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7036), new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7047), new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7051), new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7055), new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Products_ProductId",
                table: "Ratings",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Products_ProductId",
                table: "Ratings");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Ratings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 932, DateTimeKind.Local).AddTicks(4124), new DateTime(2021, 4, 12, 18, 2, 51, 934, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2339), new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2372), new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2379), new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2385), new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2391), new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2398), new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2404), new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2412), new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2418), new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2425), new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2431), new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2437), new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2444), new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2452), new DateTime(2021, 4, 12, 18, 2, 51, 935, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Products_ProductId",
                table: "Ratings",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
