using System;

namespace Labs4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(100);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            stack.Peak();
            stack.Display();


        }

    }
}