using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Globalization;
using TestTask.Data;
using TestTask.Models;

namespace TestTask.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeesController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]

        //GetData() returns Json for DataTable
        public IActionResult GetData()
        {
            IEnumerable<Employee> objList = _db.Employees;
            var data = _db.Employees.ToList();
            return new JsonResult(data);
        }
        public IActionResult Index(List<Employee> employees = null)
        {
            employees = employees == null ? new List<Employee>() : employees;

            return View(employees);
        }


        [HttpPost]
        //Uplod and Read CSV files and save to database
        public IActionResult Index(IFormFile file, [FromServices] Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            #region Upload CSV
            string fileName = $"{hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            var employees = this.GetEmployeeList(file.FileName);
            return Index(employees);
            #endregion
        }

        private List<Employee> GetEmployeeList(string fileName)
        {
            List<Employee> employees = new List<Employee>();
            #region Read CSV
            var path = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\files"}" + "\\" + fileName;
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var employee = csv.GetRecord<Employee>();
                    employees.Add(employee);
                    _db.Employees.Add(employee);
                    _db.SaveChanges();
                }
            }

            #endregion

            #region Craete CSV
            path = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\FilesTo"}";
            using (var write = new StreamWriter(path + "\\NewFile.csv"))
            using (var csv = new CsvWriter(write, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(employees);
            }
            #endregion

            return employees;
        }
    }
}
