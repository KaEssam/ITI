using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Number number = new Number();
            Thread thread1 = new Thread(() => number.Factorial(5));
            Thread thread2 = new Thread(() => number.Sum(10, 5));
            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Both threads have completed their tasks.");
        }
    }

    internal class Number
    {
        public void Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Factorial of {n} is {result}");
            Thread.Sleep(3000);
        }

        public void Sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"Sum of {a} and {b} is {sum}");
        }
    }
}