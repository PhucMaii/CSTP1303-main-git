using System;
using System.Diagnostics;

namespace Assignment3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Test classes
            var truck = new Truck(1, "Hudson");
            var car = new Car(2, "Toyota");
            var motorbike = new Motorbike(3, "Ducati");
            var bus = new Bus(4, "School Bus");

            Console.WriteLine(truck.GetInfo());
            Console.WriteLine(car.GetInfo());
            Console.WriteLine(motorbike.GetInfo());
            Console.WriteLine(bus.GetInfo());

        }
    }
}