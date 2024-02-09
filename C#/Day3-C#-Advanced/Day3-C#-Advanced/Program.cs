using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_C__Advanced
{
    internal partial class Program
    {
        public static object Utilities { get; private set; }

        private static void Main(string[] args)
        {
            #region Point2D

            //Point2D point1 = new Point2D { X = 3, Y = 4 };
            //Point2D point2 = new Point2D { X = 5, Y = 2 };

            //int result = point1.CompareTo(point2);

            //if (result < 0)
            //    Console.WriteLine("Point1 is less than Point2");
            //else if (result > 0)
            //    Console.WriteLine("Point1 is greater than Point2");
            //else
            //    Console.WriteLine("Point1 is equal to Point2");

            #endregion Point2D

            #region sort an array of points.

            //Point2D[] points = new Point2D[]
            //{
            //new Point2D { X = 3, Y = 4 },
            //new Point2D { X = 1, Y = 2 },
            //new Point2D { X = 5, Y = 3 }

            //};

            //Array.Sort(points);

            //foreach (var point in points)
            //{
            //    Console.WriteLine($"({point.X}, {point.Y})");
            //}

            #endregion sort an array of points.

            #region Student

            //Grade grade = new Grade();

            //grade["Karim"] = 3.5f;
            //grade["Essam"] = 4.0f;
            //grade["Noor"] = 3.7f;

            //Console.WriteLine("Karim's GPA: " + grade["Karim"]);

            //Console.WriteLine("First student: " + grade[0].Name);

            //Console.WriteLine("All students:");
            //foreach (var student in grade)
            //{
            //    Console.WriteLine($"{student.Name}: {student.GPA}");
            //}

            #endregion Student

            #region Utilities

            //int maxInt = Math.Max(Math.Max(5, 8), Math.Max(3, 10));
            //Console.WriteLine("Max integer: " + maxInt);

            //double maxDouble = Math.Max(Math.Max(5.6, 8.9), Math.Max(3.2, 10.1));
            //Console.WriteLine("Max double: " + maxDouble);

            //int intValue;
            //bool intParseResult = int.TryParse("123", out intValue);
            //Console.WriteLine("Int parse result: " + intParseResult + ", value: " + intValue);

            //double doubleValue;
            //bool doubleParseResult = double.TryParse("3.14", out doubleValue);
            //Console.WriteLine("Double parse result: " + doubleParseResult + ", value: " + doubleValue);

            //string invalidValue = "abc";
            //bool invalidParseResult = int.TryParse(invalidValue, out int result);
            //Console.WriteLine($"Parsing '{invalidValue}' as int: {invalidParseResult}, result: {result}");

            #endregion Utilities

            Console.ReadLine();
        }
    }
}