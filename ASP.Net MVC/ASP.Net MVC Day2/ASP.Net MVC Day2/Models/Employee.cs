using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Net_MVC_Day2.Models
{
    public class Employee
    {
            public int ID { get; set; }
            public string Name { get; set; }

            public decimal Salary { get; set; }
            public int Age { get; set; } 
    }
}