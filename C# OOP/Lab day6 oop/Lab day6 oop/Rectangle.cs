
namespace Lab_day6_oop
{
    class Rectangle : Geoshape
    {
        public Rectangle()
        {
        }

        public Rectangle(double _d1, double _d2) : base(_d1, _d2)
        {
        }

        public override double CArea()
        {
            return dim1 * dim2;
        }

        public override void Show()
        {
            Console.WriteLine("I'm Rectangle");
        }
    }
}
