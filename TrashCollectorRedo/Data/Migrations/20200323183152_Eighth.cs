using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorRedo.Data.Migrations
{
    public partial class Eighth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e67a5ee-c28c-419a-b253-b51309a8c896");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbd4c669-e179-4a5c-b1e3-5dfa5e17f12c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d740df0-8310-41fe-bbbd-79da1bb4983f", "5db9ee27-2aba-49f0-8db6-6908992c6bee", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0aaba838-7de2-4cf5-87b3-7cb16e59926d", "cc39f206-3869-42ae-ae7d-7f90ae4fd67f", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0aaba838-7de2-4cf5-87b3-7cb16e59926d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d740df0-8310-41fe-bbbd-79da1bb4983f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e67a5ee-c28c-419a-b253-b51309a8c896", "ed972e1e-46f1-4a3c-a7aa-7b11b0391d0a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fbd4c669-e179-4a5c-b1e3-5dfa5e17f12c", "a7569965-5df1-4923-a96b-af9366ff6de6", "Employee", "EMPLOYEE" });
        }
    }
}
