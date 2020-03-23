using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorRedo.Data.Migrations
{
    public partial class FirstAfterInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b7cad96-8539-41d0-ad04-971ca92d232e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce80607b-a3b9-40ef-9c11-1a970c4b5272", "26b4e0ba-bd78-42dd-9af8-ef27e1cf09d8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "841c84c3-2de9-439a-bef2-3ef66a053872", "b1c2e14c-129a-42d7-a4c3-49c16a57e488", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "841c84c3-2de9-439a-bef2-3ef66a053872");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce80607b-a3b9-40ef-9c11-1a970c4b5272");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b7cad96-8539-41d0-ad04-971ca92d232e", "de4992d3-9d6e-44ce-9fea-bf1f596a50e0", "Admin", "ADMIN" });
        }
    }
}
