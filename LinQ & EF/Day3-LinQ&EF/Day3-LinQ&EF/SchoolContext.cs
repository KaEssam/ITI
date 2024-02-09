using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_LinQ_EF
{
    internal class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolDB")
        {
        }

        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<TeacherTransfere> TeacherTransfere { get; set; }
    }
}