namespace Day3_C__Advanced
{
    internal partial class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public float GPA { get; set; }

            public Student(string name, float gpa)
            {
                Name = name;
                GPA = gpa;
            }
        }
    }
}