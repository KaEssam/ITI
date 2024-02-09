using System;

namespace Day3_C__Advanced
{
    public class Utilities
    {
        public static int Max(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("No numbers provided");
            }

            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        public static T Max<T>(params T[] items) where T : IComparable<T>
        {
            if (items.Length == 0)
            {
                throw new ArgumentException("No items provided");
            }

            T max = items[0];
            foreach (T item in items)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static bool TryParse<T>(string value, out T result)
        {
            try
            {
                result = (T)Convert.ChangeType(value, typeof(T));
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }
    }
}