using System;
using System.Collections.Generic;

namespace Day2_C__Advanced
{
    public class Trainee : IPayable, IComparer<Trainee>
    {
        private double salary;

        public string Name { get; set; }
        public string FirstName { get; set; }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 3000)
                {
                    throw new TraineeSalaryBelowThresholdException("Trainee salary cannot be below 3000.");
                }
                salary = value;
            }
        }

        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(string name, string firstName, double salary, int workingHours, int schoolHours)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public Trainee()
        {
        }

        // Methods
        public void Work()
        {
            Console.WriteLine("{0} {1} is working for {2} hours.", FirstName, Name, WorkingHours);
        }

        public void Learn()
        {
            Console.WriteLine("{0} {1} is learning for {2} hours.", FirstName, Name, SchoolHours);
        }

        public void ShowPayment()
        {
            Console.WriteLine("{0} {1} earns ${2} per month.", FirstName, Name, Salary);
        }

        public int Compare(Trainee x, Trainee y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }
}