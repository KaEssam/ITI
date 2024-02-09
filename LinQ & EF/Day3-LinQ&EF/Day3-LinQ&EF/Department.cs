using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_LinQ_EF
{
    internal class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public IList<School> schools { get; set; }
    }
}