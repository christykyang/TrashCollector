using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash.Data.Migrations
{
    public partial class Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "812ba954-8529-4d0f-9e4e-6430905e00f1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b403813b-82be-4bf4-8267-6cb4126ce37a", "1b567822-afd2-406b-b7ef-86e39b9c1a7c", "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b403813b-82be-4bf4-8267-6cb4126ce37a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "812ba954-8529-4d0f-9e4e-6430905e00f1", "adf92fad-86bd-4e6b-b71b-51880e503307", "Christy", "Employee" });
        }
    }
}
