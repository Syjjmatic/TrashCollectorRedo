using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorRedo.Data.Migrations
{
    public partial class Seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26327b85-09cb-46c1-b40f-002170de6e0a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a8c4a85-67e9-4606-aa83-98d127d86847");

            migrationBuilder.AlterColumn<string>(
                name: "PickupDay",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e67a5ee-c28c-419a-b253-b51309a8c896", "ed972e1e-46f1-4a3c-a7aa-7b11b0391d0a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fbd4c669-e179-4a5c-b1e3-5dfa5e17f12c", "a7569965-5df1-4923-a96b-af9366ff6de6", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e67a5ee-c28c-419a-b253-b51309a8c896");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbd4c669-e179-4a5c-b1e3-5dfa5e17f12c");

            migrationBuilder.AlterColumn<int>(
                name: "PickupDay",
                table: "Customer",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "26327b85-09cb-46c1-b40f-002170de6e0a", "b7b4251b-4ba6-41bf-a529-54887d096aea", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3a8c4a85-67e9-4606-aa83-98d127d86847", "473c0f8f-56d7-4927-b0d1-dac96f12b0d2", "Employee", "EMPLOYEE" });
        }
    }
}
