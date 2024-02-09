#region Task 1,2

using System;

public class Employee
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


class progeam
{

    static void Main()
    {
        Employee[] employees = new Employee[3];

        for (int i = 0; i < employees.Length; i++)
        {
            employees[i] = new Employee();

            Console.WriteLine("Enter details for employee " + (i + 1) + ":");
            Console.Write("ID: ");
            employees[i].Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            employees[i].Name = Console.ReadLine();
            Console.Write("Age: ");
            employees[i].Age = int.Parse(Console.ReadLine());
            Console.Write("Salary: ");
            employees[i].Salary = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine("Details for employee " + (i + 1) + ":");
            employees[i].PrintEmployee();
        }
    }
}
#endregion