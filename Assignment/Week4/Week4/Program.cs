using System;

namespace Week4
{
    internal class Program
    {
        static int[] numbers = new int[] { 17, 23, 47 };

        static void Main(string[] args)
        {
            Color c2 = Color.Green;
            var Car = new Car(Color.Red);

            Console.WriteLine(c2);
            Console.WriteLine(Car.GetColor());
        }

   
    }
}
