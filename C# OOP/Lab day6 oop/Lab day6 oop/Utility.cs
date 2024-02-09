
namespace Lab_day6_oop
{
    class Utility
    {
        public static double SumOfAreasV1(Rectangle r, Square s, Circle c, Triangle t)
        {
            double sum = 0;
            sum += r.CArea();
            sum += s.CArea();
            sum += c.CArea();
            sum += t.CArea();
            return sum;
        }

        public static double SumOfAreasV2(Geoshape[] Geoshapes)
        {
            double sum = 0;
            for (int i = 0; i < Geoshapes.Length; i++)
            {
                sum += Geoshapes[i].CArea();
            }
            return sum;
        }
    }
}
