using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Backend.Migrations
{
    public partial class DeleteUnitStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitsInStock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UnitsOnOrder",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 58, 29, 935, DateTimeKind.Local).AddTicks(8637), new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5389), new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5520), new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5528), new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5535), new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5542), new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5549), new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5555), new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5563), new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5569), new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5576), new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5582), new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5589), new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5595), new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5602), new DateTime(2021, 4, 13, 10, 58, 29, 937, DateTimeKind.Local).AddTicks(5604) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitsInStock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitsOnOrder",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UnitsInStock", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 397, DateTimeKind.Local).AddTicks(4679), 10, new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UnitsInStock", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(6984), 10, new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UnitsInStock", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(6998), 10, new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UnitsInStock", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7002), 10, new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UnitsInStock", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7007), 10, new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UnitsInStock", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7011), 10, new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UnitsInStock", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7015), 10, new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UnitsInStock", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7020), 10, new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UnitsInStock", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7024), 10, new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UnitsInStock", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7028), 10, new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UnitsInStock", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7032), 10, new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UnitsInStock", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7036), 10, new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UnitsInStock", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7047), 10, new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UnitsInStock", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7051), 10, new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UnitsInStock", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7055), 10, new DateTime(2021, 4, 13, 10, 29, 49, 399, DateTimeKind.Local).AddTicks(7056) });
        }
    }
}
