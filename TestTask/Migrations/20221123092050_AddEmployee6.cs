using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTask.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployee6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Start_Date",
                table: "Employees",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "Payroll_Number",
                table: "Employees",
                newName: "PayrollNumber");

            migrationBuilder.RenameColumn(
                name: "EMail_Home",
                table: "Employees",
                newName: "EMailHome");

            migrationBuilder.RenameColumn(
                name: "Date_of_Birth",
                table: "Employees",
                newName: "DateofBirth");

            migrationBuilder.RenameColumn(
                name: "Address_2",
                table: "Employees",
                newName: "Address2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Employees",
                newName: "Start_Date");

            migrationBuilder.RenameColumn(
                name: "PayrollNumber",
                table: "Employees",
                newName: "Payroll_Number");

            migrationBuilder.RenameColumn(
                name: "EMailHome",
                table: "Employees",
                newName: "EMail_Home");

            migrationBuilder.RenameColumn(
                name: "DateofBirth",
                table: "Employees",
                newName: "Date_of_Birth");

            migrationBuilder.RenameColumn(
                name: "Address2",
                table: "Employees",
                newName: "Address_2");
        }
    }
}
