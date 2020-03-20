using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash.Data.Migrations
{
    public partial class AddedCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30c2f230-a073-4a53-99e3-601bdef17018");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d897a77c-2b65-464e-ab0e-544492b5e6ad");

            migrationBuilder.AlterColumn<int>(
                name: "StartSupension",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OneTimePickUp",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EndSuspension",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a0b8508-712b-4670-9fb7-80611393a317", "06a10c2f-2190-48a6-a8a4-75e45cc47317", "Employee", "EMPLOYEE" },
                    { "51db0e46-441c-47ff-ba71-347bdc5af335", "8a2c9e86-94dc-4012-adc7-1297c6491b7f", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Balance", "City", "CustomerId1", "EndSuspension", "FirstName", "IdentityUserId", "LastName", "OneTimePickUp", "PickUpDay", "StartSupension", "State", "StreetAddress", "Zipcode", "isSuspended" },
                values: new object[,]
                {
                    { 1, 0, "Puppy Town", null, 0, "Neko", null, "Yang", 11, "Monday", 0, "Dog World", "123 1st Street", 2, false },
                    { 2, 0, "Puppy Town", null, 0, "Nel", null, "Yang", 5, "Wednesday", 0, "Dog World", "456 2nd Street", 16, false },
                    { 3, 0, "Puppy Town", null, 0, "Nyx", null, "Yang", 1, "Friday", 0, "Dog World", "789 3rd Street", 16, false }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Zipcode",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "Zipcode",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a0b8508-712b-4670-9fb7-80611393a317");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51db0e46-441c-47ff-ba71-347bdc5af335");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "StartSupension",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "OneTimePickUp",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "EndSuspension",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d897a77c-2b65-464e-ab0e-544492b5e6ad", "334681a8-d6ae-4530-bf1c-bc7e1c8c1bbd", "Employee", "EMPLOYEE" },
                    { "30c2f230-a073-4a53-99e3-601bdef17018", "c9e57773-3e54-4052-8602-9e1547959343", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Zipcode",
                value: 53035);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "Zipcode",
                value: 53022);
        }
    }
}
