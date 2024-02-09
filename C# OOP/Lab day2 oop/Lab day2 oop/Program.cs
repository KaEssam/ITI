using System;

class Program
{
    static void Main()
    {


        #region Task 1

        // 1- array of 10 integers and get min and max value


        //Console.WriteLine("Enter the values separated by spaces:");


        //string[] inputValues = Console.ReadLine().Split(' ');


        //int[] numbers = new int[inputValues.Length];


        //for (int i = 0; i < inputValues.Length; i++)
        //{
        //    if (int.TryParse(inputValues[i], out int parsedValue))
        //    {
        //        numbers[i] = parsedValue;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please enter valid integers separated by spaces.");
        //        return;
        //    }
        //}


        //int minValue = numbers[0];
        //int maxValue = numbers[0];

        //for (int i = 1; i < numbers.Length; i++)
        //{
        //    if (numbers[i] < minValue)
        //    {
        //        minValue = numbers[i];
        //    }

        //    if (numbers[i] > maxValue)
        //    {
        //        maxValue = numbers[i];
        //    }
        //}


        //Console.WriteLine("Minimum Value: " + minValue);
        //Console.WriteLine("Maximum Value: " + maxValue);

        #endregion


        #region Task 2

        // 2- array of 10 integers and sort it ascending without any built in function


        //int[] arr = new int[10];


        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write($"Enter element {i + 1}: ");
        //    while (!int.TryParse(Console.ReadLine(), out arr[i]))
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid integer.");
        //        Console.Write($"Enter element {i + 1}: ");
        //    }
        //}


        //for (int i = 0; i < arr.Length - 1; i++)
        //{
        //    for (int j = 0; j < arr.Length - 1 - i; j++)
        //    {
        //        if (arr[j] > arr[j + 1])
        //        {

        //            int temp = arr[j];
        //            arr[j] = arr[j + 1];
        //            arr[j + 1] = temp;
        //        }
        //    }
        //}


        //Console.WriteLine("The sorted array in ascending order is:");
        //foreach (int num in arr)
        //{
        //    Console.Write(num + " ");
        //}


        #endregion


        #region Task 3

        // 3- array of 10 integers and search number and get index

        //int[] arr = new int[10];


        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write($"Enter element {i + 1}: ");
        //    while (!int.TryParse(Console.ReadLine(), out arr[i]))
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid integer.");
        //        Console.Write($"Enter element {i + 1}: ");
        //    }
        //}

        //Console.Write("Enter the number to search: ");
        //if (!int.TryParse(Console.ReadLine(), out int searchNumber))
        //{
        //    Console.WriteLine("Invalid input. Please enter a valid integer.");
        //    return;
        //}


        //int index = -1;
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] == searchNumber)
        //    {
        //        index = i;
        //        break;
        //    }
        //}

        //if (index != -1)
        //{
        //    Console.WriteLine($"The number {searchNumber} is found at index {index}.");
        //}
        //else
        //{
        //    Console.WriteLine($"The number {searchNumber} is not found in the array.");
        //}

        #endregion


        #region Task 4

        // 4- array of 3 rows,4 cols read and write 

        //int[,] arr = new int[3, 4];


        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 4; j++)
        //    {
        //        Console.WriteLine("Enter the value for row {0} and column {1}:", i + 1, j + 1);
        //        arr[i, j] = Convert.ToInt32(Console.ReadLine());
        //    }
        //}


        //Console.WriteLine("The array you entered is:");


        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 4; j++)
        //    {
        //        Console.Write(arr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}


        #endregion


        #region Task 5

        // 5- calculate your birth date


        Console.Write("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        Console.Write("Enter your birth month: ");
        int birthMonth = int.Parse(Console.ReadLine());

        Console.Write("Enter your birth day: ");
        int birthDay = int.Parse(Console.ReadLine());

        DateTime currentDate = DateTime.Now;

        DateTime birthdate = new DateTime(birthYear, birthMonth, birthDay);

        int CalculateAge(DateTime birthdate, DateTime currentDate)
        {
            int age = currentDate.Year - birthdate.Year;

            if (currentDate.Month < birthdate.Month || (currentDate.Month == birthdate.Month && currentDate.Day < birthdate.Day))
            {
                age--;
            }

            return age;
        }

        int age = CalculateAge(birthdate, currentDate);


        int years = age;
        int months = (currentDate.Month - birthdate.Month + 12) % 12;
        int daysInCurrentMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
        int days = Math.Min(daysInCurrentMonth - birthdate.Day + 1 + currentDate.Day, daysInCurrentMonth);


        Console.WriteLine($"Your age is: {years} years, {months} months, and {days} days");





        #endregion


    }
}
