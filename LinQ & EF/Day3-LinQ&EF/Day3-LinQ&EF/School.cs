using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_LinQ_EF
{
    internal class School
    {
        [Key]
        public int SchoolID { get; set; }

        public string SchoolName { get; set; }
        public string SchoolType { get; set; }
        public Department Department { get; set; }
        public IList<Teacher> Teachers { get; set; }

        [InverseProperty("FromSchool")]
        public IList<TeacherTransfere> FromSchool { get; set; }

        [InverseProperty("ToSchool")]
        public IList<TeacherTransfere> ToSchool { get; set; }
    }
}