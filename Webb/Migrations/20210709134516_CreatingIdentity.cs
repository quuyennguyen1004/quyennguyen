using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Webb.Migrations
{
    public partial class CreatingIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "338ad38d-a587-4f40-9c0f-6baa59e317ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a10da830-74d0-4ffc-ae64-622ca9d162ea");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ebe641da-5eb0-4ada-8f03-fade2345ce68", "c319d6f5-e80a-4bbe-8774-d734bd85c80d", "Visitor", "VISITOR" },
                    { "7237b25f-c694-45e2-a276-cb3b4ac54b8a", "009ee487-bdba-4b34-a266-3a4e4a29e621", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 15, 513, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 15, 514, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 15, 514, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 15, 514, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 15, 514, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 15, 514, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 15, 514, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 15, 514, DateTimeKind.Local).AddTicks(3103));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7237b25f-c694-45e2-a276-cb3b4ac54b8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebe641da-5eb0-4ada-8f03-fade2345ce68");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a10da830-74d0-4ffc-ae64-622ca9d162ea", "6e8234b2-51e1-4ef9-8fff-7ed6676bafba", "Visitor", "VISITOR" },
                    { "338ad38d-a587-4f40-9c0f-6baa59e317ca", "bb132683-4b85-4cbb-8900-605200f30dfa", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 51, 616, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 51, 616, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 51, 616, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 51, 616, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 51, 616, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 51, 616, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 51, 616, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 51, 616, DateTimeKind.Local).AddTicks(9235));
        }
    }
}
