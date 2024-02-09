using System;

namespace Day2_C__Advanced
{
    public class Employee : IPayable
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string firstName, double salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("{0} {1} is working.", FirstName, Name);
        }

        public void Pause()
        {
            Console.WriteLine("{0} {1} is taking a break.", FirstName, Name);
        }

        public void ShowPayment()
        {
            Console.WriteLine("{0} {1} earns ${2} per month.", FirstName, Name, Salary);
        }
    }
}