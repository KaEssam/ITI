using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Net_MVC_Day1.Models
{
    public class CompanyDBContext
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee() { ID = 1, Name = "Karim" },
            new Employee() { ID = 2, Name = "Essam" }

        };
    }
}