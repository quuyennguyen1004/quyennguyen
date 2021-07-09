using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Webb.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1466f4c6-6b97-4d2a-9d9a-2e7185998bae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81076c03-37ef-4ac1-961c-8684d4d1baa9");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "81076c03-37ef-4ac1-961c-8684d4d1baa9", "cd0c718f-4071-449a-9409-af1910240c33", "Visitor", "VISITOR" },
                    { "1466f4c6-6b97-4d2a-9d9a-2e7185998bae", "2f0446b7-d160-415d-80cd-d91d8219f0be", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 30, 840, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 30, 841, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 30, 841, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 30, 841, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 30, 841, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 30, 841, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 30, 841, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 44, 30, 841, DateTimeKind.Local).AddTicks(4413));
        }
    }
}
