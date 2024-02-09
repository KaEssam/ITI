using System;
using System.Collections.Generic;
using System.Linq;

namespace Day4_CSharp_Advanced
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Karim", Salary = 8000, Gender = "Male", Experience = 3 },
                new Employee { Id = 2, Name = "Noor", Salary = 12000, Gender = "Female", Experience = 6 },
                new Employee { Id = 3, Name = "Ahmed", Salary = 15000, Gender = "Male", Experience = 8 },
                new Employee { Id = 4, Name = "Marim", Salary = 5000, Gender = "Female", Experience = 2 }
            };

            var salaryPromotion = Promote(employees, emp => emp.Salary < 10000);
            Console.WriteLine("Promoted based on Salary < 10000:");
            foreach (var emp in salaryPromotion)
            {
                Console.WriteLine($"{emp.Name} - Salary: {emp.Salary}");
            }

            var experiencePromotion = Promote(employees, emp => emp.Experience > 5);
            Console.WriteLine("\nPromoted based on Experience > 5 years:");
            foreach (var emp in experiencePromotion)
            {
                Console.WriteLine($"{emp.Name} - Experience: {emp.Experience} years");
            }

            Console.ReadLine();
        }

        public static List<Employee> Promote(List<Employee> employees, Func<Employee, bool> promotionCriteria)
        {
            return employees.Where(emp => promotionCriteria(emp)).ToList();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
    }
}