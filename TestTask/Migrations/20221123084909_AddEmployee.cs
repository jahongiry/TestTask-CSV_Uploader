using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTask.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Employees",
                newName: "Telephone");

            migrationBuilder.RenameColumn(
                name: "Personal_Record",
                table: "Employees",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Employees",
                newName: "Start_Date");

            migrationBuilder.RenameColumn(
                name: "IdNumber",
                table: "Employees",
                newName: "Postcode");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Employees",
                newName: "Mobile");

            migrationBuilder.RenameColumn(
                name: "EnteredDate",
                table: "Employees",
                newName: "Forenames");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Employees",
                newName: "EMail_Home");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Employees",
                newName: "Date_of_Birth");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Employees",
                newName: "Address_2");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Employees",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Employees",
                newName: "Payroll_Number");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "Employees",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Employees",
                newName: "Personal_Record");

            migrationBuilder.RenameColumn(
                name: "Start_Date",
                table: "Employees",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Postcode",
                table: "Employees",
                newName: "IdNumber");

            migrationBuilder.RenameColumn(
                name: "Mobile",
                table: "Employees",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Forenames",
                table: "Employees",
                newName: "EnteredDate");

            migrationBuilder.RenameColumn(
                name: "EMail_Home",
                table: "Employees",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Date_of_Birth",
                table: "Employees",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "Address_2",
                table: "Employees",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Employees",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "Payroll_Number",
                table: "Employees",
                newName: "UserName");
        }
    }
}
