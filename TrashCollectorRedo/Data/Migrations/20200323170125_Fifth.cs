using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorRedo.Data.Migrations
{
    public partial class Fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1de36875-5bc4-43dd-8256-5d7ff5f234a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4009875-a0d9-4dc0-b2a3-31f9e81202ef");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SuspendStart",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SuspendEnd",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OneTimePickup",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e421b27-5234-4f62-b5ed-fbf5ab2dc88b", "283f04e2-9faa-403c-a1eb-9239861e72d7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31a7043d-2244-47c4-9803-54201ebc67e5", "006d46d8-d350-419e-8cd7-bfcd48969594", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31a7043d-2244-47c4-9803-54201ebc67e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e421b27-5234-4f62-b5ed-fbf5ab2dc88b");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SuspendStart",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SuspendEnd",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OneTimePickup",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1de36875-5bc4-43dd-8256-5d7ff5f234a8", "061f7570-7c9d-4ca4-8470-668daf14221c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4009875-a0d9-4dc0-b2a3-31f9e81202ef", "64b6765d-f162-43ce-a115-7381f11aff9c", "Employee", "EMPLOYEE" });
        }
    }
}
