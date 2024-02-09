using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_day3_oop
{
    internal class Student
    {
        private string name;
        private int age;
        private double gpa;


        public void SetName(string n) { name = n; }
        public void SetAge(int a) { age = a; }
        public void SetGPA(double g) { gpa = g; }


        public string GetName() { return name; }
        public int GetAge() { return age; }
        public double GetGPA() { return gpa; }


        public void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"GPA: {gpa}");
        }


        public static void PrintArray(Student[] students)
        {
            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine($"Student {i + 1}:");
                students[i].Print();
                Console.WriteLine();
            }
        }
    }
}
