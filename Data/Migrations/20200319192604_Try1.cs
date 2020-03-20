using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash.Data.Migrations
{
    public partial class Try1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b403813b-82be-4bf4-8267-6cb4126ce37a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d3a6b69d-4123-4aa6-9b36-25b4805aa36b", "395b1af0-a1dd-4b0c-9f06-60609a93be6c", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3a6b69d-4123-4aa6-9b36-25b4805aa36b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b403813b-82be-4bf4-8267-6cb4126ce37a", "1b567822-afd2-406b-b7ef-86e39b9c1a7c", "Admin", "Admin" });
        }
    }
}
