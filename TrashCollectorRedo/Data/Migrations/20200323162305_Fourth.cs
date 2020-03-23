using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorRedo.Data.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37a868bf-23ba-404a-a4b2-98ead9c6de6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efea8cef-fd02-4d3c-8436-c23f412cd070");

            migrationBuilder.AddColumn<int>(
                name: "Balance",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PickupDay",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspendEnd",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspendStart",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1de36875-5bc4-43dd-8256-5d7ff5f234a8", "061f7570-7c9d-4ca4-8470-668daf14221c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4009875-a0d9-4dc0-b2a3-31f9e81202ef", "64b6765d-f162-43ce-a115-7381f11aff9c", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1de36875-5bc4-43dd-8256-5d7ff5f234a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4009875-a0d9-4dc0-b2a3-31f9e81202ef");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "PickupDay",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "SuspendEnd",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "SuspendStart",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "efea8cef-fd02-4d3c-8436-c23f412cd070", "3626afce-1bc9-4ff1-9e0e-772199a832a5", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37a868bf-23ba-404a-a4b2-98ead9c6de6a", "29f54f37-6e14-40e6-987a-22f86fd58bbd", "Employee", "EMPLOYEE" });
        }
    }
}
