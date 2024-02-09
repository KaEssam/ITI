using System;

namespace Day3_C__Advanced
{
    public class Point2D : IComparable<Point2D>
    {
        public int X { get; set; }

        public int Y { get; set; }

        internal int CompareTo(Point2D point2)
        {
            if (this.X == point2.X && this.Y == point2.Y)
                return 0;
            else if (this.X > point2.X && this.Y > point2.Y)
                return 1;
            else
                return -1;
        }

        int IComparable<Point2D>.CompareTo(Point2D other)
        {
            if (this.X > other.X)
                return 1;
            else if (this.X < other.X)
                return -1;
            else
                return 0;
        }
    }
}