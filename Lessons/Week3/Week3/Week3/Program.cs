using System;
using Week3;

namespace week3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program was called");

            var duck1 = new Duck(1, "Tony");
            Console.WriteLine(duck1.GetInfo());

            var rhduck2 = new RedHeadDuck(2, "Phil");
            Console.WriteLine(rhduck2.GetInfo());
        }
    }
}