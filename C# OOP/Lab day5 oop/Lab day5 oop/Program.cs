
namespace Lab_day5_oop
{
    class Program
    {
        static void Main()
        {

            #region implement Stack

            Console.Write("Enter integer values for Stack (separated by space): ");
            int[] stackValues = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Stack<int> myStack = new Stack<int>();
            foreach (var value in stackValues)
            {
                myStack.Push(value);
            }

            Console.WriteLine("\nStack values:");
            while (myStack.Count > 0)
            {
                Console.WriteLine($"Popped: {myStack.Pop()}");
            }

            #endregion


            #region implement Complex


            Console.Write("Enter real part for Complex: ");
            double realPart = double.Parse(Console.ReadLine());

            Console.Write("Enter imaginary part for Complex: ");
            double imaginaryPart = double.Parse(Console.ReadLine());

            Complex c1 = new Complex(realPart, imaginaryPart);


            Console.WriteLine("\nComplex value:");
            c1.Display();


            #endregion


            #region implement Employee


            Employee emp = new Employee();

            Console.Write("Enter Employee ID: ");
            emp.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Enter Employee Age: ");
            emp.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Salary: ");
            emp.Salary = double.Parse(Console.ReadLine());


            Console.WriteLine("\nEmployee details:");
            Console.WriteLine($"Employee ID: {emp.Id}");
            Console.WriteLine($"Employee Name: {emp.Name}");
            Console.WriteLine($"Employee Age: {emp.Age}");
            Console.WriteLine($"Employee Salary: {emp.Salary}");


            #endregion



           









        }
    }
}



