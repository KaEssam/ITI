using System;
using System.Reflection;

namespace Lab_day3_oop
{
    class Program
    {
        static void Main()
        {

            #region Employee

            // 1- one employee read and write

            Employee employee = ReadEmployee();
            Console.WriteLine("Employee Information:");
            PrintEmployee(employee);

            //2 - array of 3 employees read at runtime and print

            Employee[] employees = new Employee[3];

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = ReadEmployeeDetails(i + 1);
            }

            Console.WriteLine("\nDetails for 3 employees:");
            PrintEmployeeArray(employees);


            static Employee ReadEmployee()
            {
                Console.WriteLine("Enter details for an employee:");
                Employee employee = new Employee();

                Console.Write("ID: ");
                employee.Id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                employee.Name = Console.ReadLine();

                Console.Write("Age: ");
                employee.Age = int.Parse(Console.ReadLine());

                Console.Write("Salary: ");
                employee.Salary = double.Parse(Console.ReadLine());

                return employee;
            }

            static Employee ReadEmployeeDetails(int employeeNumber)
            {
                Console.WriteLine($"Enter details for employee {employeeNumber}:");
                return ReadEmployee();
            }

            static void PrintEmployee(Employee employee)
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Age: {employee.Age}, Salary: {employee.Salary}");
            }

            static void PrintEmployeeArray(Employee[] employees)
            {
                foreach (var emp in employees)
                {
                    PrintEmployee(emp);
                }
            }


            //5- array of 10 employees and choose index

            Employee[] employeesArray = new Employee[10];

            for (int i = 0; i < employeesArray.Length; i++)
            {
                employeesArray[i] = ReadEmployeeDetails(i + 1);
            }

            char choice;
            do
            {
                Console.WriteLine("\nEnter employee index to print (0-9), or press 'N' to print all employees:");
                choice = char.ToUpper(Console.ReadKey().KeyChar);

                if (choice >= '0' && choice <= '9')
                {
                    int index = choice - '0';
                    if (index < employeesArray.Length && employeesArray[index] != null)
                    {
                        Console.WriteLine($"\nDetails for the selected employee at index {index}:");
                        PrintEmployee(employeesArray[index]);
                    }
                    else
                    {
                        Console.WriteLine($"No employee entered at index {index}.");
                    }
                }
                else if (choice == 'N')
                {
                    Console.WriteLine("\nPrinting all entered employees:");
                    PrintEmployeeArray(employeesArray);
                }
                else if (choice != 'N')
                {
                    Console.WriteLine("Invalid input. Please enter a valid index (0-9) or 'N' to print all employees.");
                }

            } while (choice != 'N');

            #endregion


            #region Student

            //3 - one student read and write

            Student singleStudent = ReadStudentDetails();
            Console.WriteLine("\nDetails for a single student:");
            PrintStudent(singleStudent);


            //4 - array of 3 students read at runtime and print

            Student[] studentsArray = new Student[3];

            for (int i = 0; i < studentsArray.Length; ++i)
            {
                studentsArray[i] = ReadStudentDetails(i + 1);
            }

            Console.WriteLine("\nDetails for 3 students:");
            PrintStudentArray(studentsArray);
        }



        static Student ReadStudentDetails(int studentNumber = 0)
        {
            Console.WriteLine($"Enter details for {(studentNumber == 0 ? "a" : "student " + studentNumber + ":")}");
            Student student = new Student();

            Console.Write("Name: ");
            student.SetName(Console.ReadLine());

            Console.Write("Age: ");
            student.SetAge(int.Parse(Console.ReadLine()));

            Console.Write("GPA: ");
            student.SetGPA(double.Parse(Console.ReadLine()));

            return student;
        }

        static void PrintStudent(Student student)
        {
            Console.WriteLine($"Name: {student.GetName()}, Age: {student.GetAge()}, GPA: {student.GetGPA()}");
        }

        static void PrintStudentArray(Student[] students)
        {
            foreach (var stud in students)
            {
                PrintStudent(stud);
            }
        }

        // 6- array of 10 Students and choose index


        #endregion



    }
}












