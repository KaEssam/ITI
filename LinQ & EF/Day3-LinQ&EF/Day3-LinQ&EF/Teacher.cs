using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_LinQ_EF
{
    internal class Teacher
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string Qualification { get; set; }
        public DateTime QualificationDate { get; set; }
        public DateTime HiringDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Job { get; set; }
        public int Code { get; set; }
        public int NationalID { get; set; }
        public string Notes { get; set; }
        public string Phone { get; set; }

        public School School { get; set; }
    }
}