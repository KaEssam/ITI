

namespace Lab_day6_oop
{
    class Triangle : Geoshape
    {
        public Triangle()
        {
        }
        public Triangle(double _base, double _height) : base(_base, _height)
        {
        }
        public override double CArea()
        {
            return 0.5 * dim1 * dim2;
        }

        public void Show()
        {
            Console.WriteLine("I'm Triangle");
        }
    }
}
