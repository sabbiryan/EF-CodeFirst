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


            Company company = new Company()
            {
                Id = Guid.NewGuid().ToString(),
                Created = DateTime.Now,
                CreatedBy = "System",
                Modified =  DateTime.Now,
                ModifiedBy =  "System",
                IsActive = true,

                Name = "Index IA Limited",
                Adddress = "House# 15, Road# 27 (Old), Dhanmondi",
                Phone = "+8800000000000"
            };

            db.Companies.Add(company);
            db.SaveChanges();
        }
    }
}
