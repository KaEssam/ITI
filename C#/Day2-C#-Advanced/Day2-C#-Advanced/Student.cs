namespace Day2_C__Advanced
{
    public class Student
    {
        private int _id;
        private string _name;

        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)

        {
            _id = id;
            _name = name;
        }

        public override string ToString()
        {
            return $"ID: {_id}, Name: {_name}";
        }
    }
}