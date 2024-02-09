﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_day3_oop
{
    internal class Employee
    {
        private int id;
        private string name;
        private int age;
        private double salary;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void PrintEmployee()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Salary: " + Salary);
        }
    }
}
