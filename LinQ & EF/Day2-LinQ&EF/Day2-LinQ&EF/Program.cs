using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_LinQ_EF
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var context = new Company_SDEntities();

            #region insert data

            //var Dep = new Departments()
            //{
            //    Dname = "HR",
            //    Dnum = 1,
            //    MGRSSN = 102672,
            //    MGRStart_Date = new DateTime(2019, 1, 1)
            //};

            //context.Departments.Add(Dep);
            //var test = context.SaveChanges();

            #endregion insert data

            #region Update data

            //var dep = context.Departments.Find(1);
            //dep.Dname = "MR";

            //context.SaveChanges();

            #endregion Update data

            #region Delete data

            //var dep = context.Departments.Find(1);

            //context.Departments.Remove(dep);

            //var test3 = context.SaveChanges();

            #endregion Delete data

            #region Try adding stored procedure in the model and use it.

            //var result = context.checkNumberOfEmployees(100);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Fname);
            //}

            #endregion Try adding stored procedure in the model and use it.

            #region Implementing concurrency mode

            var context1 = new Company_SDEntities();

            Employee Emp = context.Employee.Find(112233);
            Employee Emp1 = context1.Employee.Find(112233);

            Emp.Salary -= 100;
            Emp1.Salary -= 500;

            context.SaveChanges();

            try
            {
                context1.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                var entry = ex.Entries.First();
                entry.Reload();

                Emp1.Salary -= 300;
                context1.SaveChanges();
            }

            #endregion Implementing concurrency mode

            Console.ReadLine();
        }
    }
}