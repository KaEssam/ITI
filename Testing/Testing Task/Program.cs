namespace TestingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WeightCalculator calculator = new WeightCalculator()
            {
                Height = 180,
                Gender = 'm'
            };

            double weight = calculator.GetWeight();

            Console.WriteLine($"Weight is : {weight}");

            if (weight == 72.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Success");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test Failed");
            }

            /////////////////////////////////////////////////

            WeightCalculator calculator1 = new WeightCalculator()
            {
                Height = 170,
                Gender = 'f'
            };

            double weight1 = calculator1.GetWeight();

            Console.WriteLine($"Weight is : {weight1}");

            if (weight1 == 60)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Success");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test Failed");
            }



            ////////////

            WeightCalculator calculator2 = new WeightCalculator()
            {
                Height = 170,
                Gender = 'k'
            };

            double weight2 = calculator1.GetWeight();

            Console.WriteLine($"Weight is : {weight2}");

            if (weight2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Success");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test Failed");
            }

            Console.ReadKey();
        }



    }
}
