using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace EF_CodeFirst_ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {

            AppContext db = new AppContext();

            string companyId = AddCompany(db);
            Commit(db);

            string employeeId = AddEmployee(db, companyId);
            Commit(db);
        }

        private static string AddEmployee(AppContext db, string companyId)
        {
            Employee employee = new Employee()
            {
                Id = Guid.NewGuid().ToString(),
                Created = DateTime.Now,
                CreatedBy = "System",
                Modified = DateTime.Now,
                ModifiedBy = "System",
                IsActive = true,

                Name = "Mehedi Sourav",
                CompanyId = companyId,
                Designation = "Software Engineer",
                JoiningDate = DateTime.Today.AddDays(-1)
            };
            db.Employees.Add(employee);

            return employee.Id;
        }

        private static bool Commit(AppContext db)
        {
            int saveChanges = db.SaveChanges();
            return saveChanges > 0;
        }

        private static string AddCompany(AppContext db)
        {

            if (db.Companies.Any())
            {
                var firstOrDefault = db.Companies.FirstOrDefault();
                if (firstOrDefault != null) return firstOrDefault.Id;
            }

            Company company = new Company()
            {
                Id = Guid.NewGuid().ToString(),
                Created = DateTime.Now,
                CreatedBy = "System",
                Modified = DateTime.Now,
                ModifiedBy = "System",
                IsActive = true,

                Name = "Index IA Limited",
                Adddress = "House# 15, Road# 27 (Old), Dhanmondi",
                Phone = "+8800000000000"
            };

            db.Companies.Add(company);

            return company.Id;
        }
    }
}
