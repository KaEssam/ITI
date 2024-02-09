using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_LinQ_EF
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                //Database.SetInitializer<SchoolContext>(new DropCreateDatabaseIfModelChanges<SchoolContext>());

                var teacher = new Teacher { TeacherName = "Karim", BirthDate = DateTime.Now, QualificationDate = DateTime.Now, HiringDate = DateTime.Now };

                ctx.Teacher.Add(teacher);
                ctx.SaveChanges();

                //var query = from t in ctx.Teacher
                //            where t.TeacherName == "Karim"
                //            select t;

                //foreach (var item in query)
                //{
                //    Console.WriteLine(item.TeacherName);
                //}
            }
        }
    }
}