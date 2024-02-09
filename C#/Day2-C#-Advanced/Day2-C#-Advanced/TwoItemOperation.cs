namespace Day2_C__Advanced
{
    public class TwoItemOperation<T>
    {
        
        public T Sum(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }

        public T Sub(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x - y;
        }

        public T Div(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x / y;
        }
    }

}