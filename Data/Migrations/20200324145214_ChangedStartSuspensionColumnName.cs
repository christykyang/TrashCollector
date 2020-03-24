using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash.Data.Migrations
{
    public partial class ChangedStartSuspensionColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_EmployeeId1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeId1",
                table: "Employees");

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

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StartSupension",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "OneTimePickUp",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "EndSuspension",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "StartSuspension",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a8f8c6d2-a50e-43be-9e13-cb83f2fd150f", "0399b607-1a7b-4e42-a4f7-a27bffb876ec", "Employee", "EMPLOYEE" },
                    { "f90d77ef-7b6a-464e-a2ce-34c90352e346", "ebf1602e-d7a5-45d1-93fc-b76f1c847067", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Zipcode",
                value: 53227);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "Zipcode",
                value: 53213);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8f8c6d2-a50e-43be-9e13-cb83f2fd150f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f90d77ef-7b6a-464e-a2ce-34c90352e346");

            migrationBuilder.DropColumn(
                name: "StartSuspension",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId1",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OneTimePickUp",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EndSuspension",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StartSupension",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeId1",
                table: "Employees",
                column: "EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_EmployeeId1",
                table: "Employees",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
