namespace Lab_day4_oop
{
    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            calculator.RunCalculator();

            ComplexNumber complex1 = new ComplexNumber(3, 4);
            ComplexNumber complex2 = new ComplexNumber();
            ComplexNumber complex3 = new ComplexNumber(1.5, 2.5);

            Console.WriteLine("Complex Number 1:");
            complex1.Display();

            Console.WriteLine("Complex Number 2:");
            complex2.Display();

            Console.WriteLine("Complex Number 3:");
            complex3.Display();

            Console.WriteLine($"Total Complex Numbers created: {ComplexNumber.GetCounter()}");
        }
    }


    class Calculator
    {
        public void RunCalculator()
        {
            do
            {
                Console.WriteLine("Enter first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter operator (+, -, *, /):");
                char op = Convert.ToChar(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case '+':
                        result = MyMath.Add(num1, num2);
                        break;
                    case '-':
                        result = MyMath.Subtract(num1, num2);
                        break;
                    case '*':
                        result = MyMath.Multiply(num1, num2);
                        break;
                    case '/':
                        try
                        {
                            result = MyMath.Divide(num1, num2);
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                            continue; // Skip further processing for this iteration
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        continue; // Skip further processing for this iteration
                }

                Console.WriteLine($"{num1} {op} {num2} = {result}");

                Console.WriteLine("Continue? (y/n):");
            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}