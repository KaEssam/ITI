using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_LinQ_EF
{
    internal class TeacherTransfere
    {
        public int TeacherTransfereID { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }

        public Teacher Teacher { get; set; }

        [ForeignKey("FromSchool")]
        public int? FromSchoolID { get; set; }

        public School FromSchool { get; set; }

        [ForeignKey("ToSchool")]
        public int? ToSchoolID { get; set; }

        public School ToSchool { get; set; }
    }
}