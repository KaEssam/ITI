using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_day4_oop
{

    public class ComplexNumber
    {
        private double real;
        private double imaginary;
        private static int counter = 0;

        // Complex constructor
        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
            counter++;
        }

        // Default constructor
        public ComplexNumber()
        {
            this.real = 0;
            this.imaginary = 0;
            counter++;
        }

        // Display method
        public void Display()
        {
            Console.WriteLine($"Complex Number: {real} + {imaginary}i");
        }

        // Static method to get the counter value
        public static int GetCounter()
        {
            return counter;
        }
    }



}

