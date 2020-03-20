using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash.Data.Migrations
{
    public partial class Try3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0049757c-0831-42a6-9b12-e8e22a4b347d", "ebdba65b-23df-4e1c-8f51-b203424d4004", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "149dd6b5-5b64-4ac9-b286-73fb11f27b2f", "aad036d7-2442-43bf-a05b-ab685d838e4b", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0049757c-0831-42a6-9b12-e8e22a4b347d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "149dd6b5-5b64-4ac9-b286-73fb11f27b2f");

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "FirstName", "IdentityUserId", "LastName", "Zipcode" },
                values: new object[] { 1, "Christy", null, "Yang", 53022 });
        }
    }
}
