using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorRedo.Data.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6603be4-3732-4988-a97e-e0e3d4fe3688");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f90be1fb-6387-40c7-8629-8ca6542bbfca");

            migrationBuilder.AddColumn<DateTime>(
                name: "OneTimePickup",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "efea8cef-fd02-4d3c-8436-c23f412cd070", "3626afce-1bc9-4ff1-9e0e-772199a832a5", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37a868bf-23ba-404a-a4b2-98ead9c6de6a", "29f54f37-6e14-40e6-987a-22f86fd58bbd", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37a868bf-23ba-404a-a4b2-98ead9c6de6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efea8cef-fd02-4d3c-8436-c23f412cd070");

            migrationBuilder.DropColumn(
                name: "OneTimePickup",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f90be1fb-6387-40c7-8629-8ca6542bbfca", "250b6725-efa3-4647-9c82-75c32b568cc1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6603be4-3732-4988-a97e-e0e3d4fe3688", "1429e8ed-2c93-4c49-bdb6-4f23348e8cc8", "Employee", "EMPLOYEE" });
        }
    }
}
