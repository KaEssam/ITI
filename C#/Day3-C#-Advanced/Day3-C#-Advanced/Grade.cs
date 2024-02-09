using System.Collections;
using System.Collections.Generic;

namespace Day3_C__Advanced
{
    internal partial class Program
    {
        public class Grade : IEnumerable<Student>
        {
            private List<Student> students = new List<Student>();

            public float this[string name]
            {
                get
                {
                    var student = students.Find(s => s.Name == name);
                    return student != null ? student.GPA : -1;
                }
                set
                {
                    var student = students.Find(s => s.Name == name);
                    if (student != null)
                    {
                        student.GPA = value;
                    }
                    else
                    {
                        students.Add(new Student(name, value));
                    }
                }
            }

            public Student this[int index]
            {
                get { return students[index]; }
            }

            public IEnumerator<Student> GetEnumerator()
            {
                return students.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}