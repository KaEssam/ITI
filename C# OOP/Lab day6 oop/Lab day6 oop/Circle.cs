

namespace Lab_day6_oop
{
    class Circle : Geoshape
    {
        public Circle()
        {
        }

        public Circle(double _radius) : base(_radius, _radius)
        {
        }

        public override double CArea()
        {
            return Math.PI * dim1 * dim2;
        }

        public void Show()
        {
            Console.WriteLine("I'm Circle");
        }

    }
}
