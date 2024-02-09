using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day2_C__Advanced.Program;

namespace Day2_C__Advanced
{
    internal partial class Program
    {
        public static void Main(string[] args)
        {
            #region Task 1

            //Student[] students = new Student[5];

            //students[0] = new Student(101, "Karim");
            //students[1] = new Student(102, "Essam");
            //students[2] = new Student(103, "Ahmed");
            //students[3] = new Student(104, "Noor");
            //students[4] = new Student(105, "Hassan");

            //Array.Sort(students, (s1, s2) => s1.Id.CompareTo(s2.Id));

            //Console.WriteLine("Sorted array by ID:");

            //foreach (Student s in students)
            //{
            //    Console.WriteLine(s);
            //}

            //try
            //{
            //    students[5] = new Student(106, "Ali");
            //}
            //catch
            //{
            //    Console.WriteLine("Error: Cannot add more items to the array. The array is full.)");
            //}

            #endregion Task 1

            #region Task 2

            //Glist<int> numberList = new Glist<int>();
            //numberList.Add(32);
            //numberList.Add(21);
            //numberList.Add(45);
            //numberList.Add(11);
            //numberList.Add(89);

            //Glist<string> authors = new Glist<string>(5);
            //authors.Add("Mahesh Chand");
            //authors.Add("Chris Love");
            //authors.Add("Allen O'neill");
            //authors.Add("Naveen Sharma");
            //authors.Add("Monica Rathbun");
            //authors.Add("David McCarter");

            //foreach (string a in (IEnumerable<string>)authors)
            //{
            //    Console.WriteLine(a);
            //}

            //foreach (int N in numberList)
            //{
            //    Console.WriteLine(N);
            //}

            #endregion Task 2

            #region Task 3 & 5

            //Employee emp = new Employee("Ali", "A", 3000);
            //emp.Work();
            //emp.ShowPayment();

            //Trainee trainee1 = new Trainee("Karim", "K", 1000, 30, 20);
            //Trainee trainee2 = new Trainee("Noor", "N", 1200, 25, 15);
            //Trainee trainee3 = new Trainee("Ahmed", "D", 800, 35, 25);

            //List<Trainee> trainees = new List<Trainee> { trainee1, trainee2, trainee3 };

            //foreach (var trainee in trainees)
            //{
            //    trainee.Work();
            //    trainee.Learn();
            //    trainee.ShowPayment();
            //    Console.WriteLine();
            //}

            //trainees.Sort(new Trainee());

            //Console.WriteLine("Trainees sorted by salary:");
            //foreach (var trainee in trainees)
            //{
            //    Console.WriteLine("{0} {1} earns ${2} per month.", trainee.FirstName, trainee.Name, trainee.Salary);
            //}

            #endregion Task 3 & 5

            #region Task 4

            //TwoItemOperation<int> intCalculator = new TwoItemOperation<int>();
            //Console.WriteLine("Sum of 5 and 3: " + intCalculator.Sum(5, 3));
            //Console.WriteLine("Subtraction of 5 and 3: " + intCalculator.Sub(5, 3));
            //Console.WriteLine("Division of 10 by 2: " + intCalculator.Div(10, 2));

            //TwoItemOperation<double> doubleCalculator = new TwoItemOperation<double>();
            //Console.WriteLine("Sum of 5.5 and 3.2: " + doubleCalculator.Sum(5.5, 3.2));
            //Console.WriteLine("Subtraction of 5.5 and 3.2: " + doubleCalculator.Sub(5.5, 3.2));
            //Console.WriteLine("Division of 10.0 by 2.5: " + doubleCalculator.Div(10.0, 2.5));

            #endregion Task 4

            Console.ReadKey();
        }
    }

    #region Glist

    //public class Glist<T> : IEnumerable<T>
    //{
    //    private T[] items;

    // public int Count { get; private set; }

    // public Glist(int capacity = 10) { if (capacity <= 0) { throw new ArgumentException("Capacity
    // Must be Positive"); }

    // items = new T[capacity];

    // Count = 0; }

    // public void Add(T item) { if (Count == items.Length) { T[] newItems = new T[items.Length * 2];

    // for (int i = 0; i < items.Length; i++) { newItems[i] = items[i]; } items = newItems; }

    // items[Count] = item; Count++; }

    // public T this[int index] { get { if ((index < 0) || (index >= Count)) throw new
    // IndexOutOfRangeException("Index out of Range");

    // return items[index]; } set { if ((index < 0) || (index >= Count)) throw new
    // IndexOutOfRangeException("Index out of Range");

    // items[index] = value; } }

    // public IEnumerator<T> GetEnumerator() { for (int i = 0; i < Count; i++) { yield return
    // items[i]; } }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return GetEnumerator();
    //    }
    //}

    #endregion Glist

    public interface IPayable
    {
        double Salary { get; set; }

        void ShowPayment();
    }
}