using System;

namespace Lab_day5_oop
{
    class Stack<T>
    {
        private T[] array;
        private int top;
        private const int MAX_SIZE = 5;

        public Stack()
        {
            array = new T[MAX_SIZE];
            top = -1;
        }

        public void Push(T value)
        {
            if (top < MAX_SIZE - 1)
            {
                array[++top] = value;
            }
            else
            {
                Console.WriteLine("Stack Overflow!");
            }
        }

        public T Pop()
        {
            if (top >= 0)
            {
                return array[top--];
            }
            else
            {
                Console.WriteLine("Stack Underflow!");
                return default(T);
            }
        }

        public int Count
        {
            get { return top + 1; }
        }
    }
}
