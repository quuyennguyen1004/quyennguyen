using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Webb.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "d0c0815b-0c02-479b-b33d-3105217e5103", "4a787677-7903-4b87-8ed2-7b0122ebfed4", "Visitor", "VISITOR" },
                    { "8c92be80-eed5-480c-a430-452ada4f0d5c", "937b717f-6ba0-4b9f-ae78-0fb7442f0af0", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 27, 585, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 27, 586, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 27, 586, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 27, 586, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 27, 586, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 27, 586, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 27, 586, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2021, 7, 9, 20, 45, 27, 586, DateTimeKind.Local).AddTicks(3607));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c92be80-eed5-480c-a430-452ada4f0d5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0c0815b-0c02-479b-b33d-3105217e5103");

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
    }
}
