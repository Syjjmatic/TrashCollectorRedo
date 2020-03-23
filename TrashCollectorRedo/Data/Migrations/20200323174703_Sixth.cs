using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorRedo.Data.Migrations
{
    public partial class Sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31a7043d-2244-47c4-9803-54201ebc67e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e421b27-5234-4f62-b5ed-fbf5ab2dc88b");

            migrationBuilder.AlterColumn<int>(
                name: "PickupDay",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "26327b85-09cb-46c1-b40f-002170de6e0a", "b7b4251b-4ba6-41bf-a529-54887d096aea", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3a8c4a85-67e9-4606-aa83-98d127d86847", "473c0f8f-56d7-4927-b0d1-dac96f12b0d2", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26327b85-09cb-46c1-b40f-002170de6e0a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a8c4a85-67e9-4606-aa83-98d127d86847");

            migrationBuilder.AlterColumn<int>(
                name: "PickupDay",
                table: "Customer",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e421b27-5234-4f62-b5ed-fbf5ab2dc88b", "283f04e2-9faa-403c-a1eb-9239861e72d7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31a7043d-2244-47c4-9803-54201ebc67e5", "006d46d8-d350-419e-8cd7-bfcd48969594", "Employee", "EMPLOYEE" });
        }
    }
}
