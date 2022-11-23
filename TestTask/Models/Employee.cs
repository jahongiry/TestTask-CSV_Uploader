using CsvHelper.Configuration.Attributes;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace TestTask.Models
{
    public class Employee
    {
        [Key]

        [Name("Personnel_Records.Payroll_Number")]
        public string PayrollNumber { get; set; }
        [Name("Personnel_Records.Forenames")]
        public string? Forename { get; set; }
        [Name("Personnel_Records.Surname")]
        public string? Surname { get; set; }
        [Name("Personnel_Records.Date_of_Birth")]
        public string? DateofBirth { get; set; }
        [Name("Personnel_Records.Telephone")]
        public string? Telephone { get; set; }
        [Name("Personnel_Records.Mobile")]
        public string? Mobile { get; set; }
        [Name("Personnel_Records.Address")]
        public string? Address { get; set; }
        [Name("Personnel_Records.Address_2")]
        public string? Address2 { get; set; }
        [Name("Personnel_Records.Postcode")]
        public string? Postcode { get; set; }
        [Name("Personnel_Records.EMail_Home")]
        public string? EMailHome { get; set; }
        [Name("Personnel_Records.Start_Date")]
        public string? StartDate { get; set; }
    }
}
