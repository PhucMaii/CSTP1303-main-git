using System;
using System.Diagnostics;

namespace Assignment4
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Test classes
            var truck = new Truck("7JZ545809Q", 45768783, "RAM", "2015", "Pickup", Color.Red, BodyType.PickUp, EngineType.Combustion, 15000, 100, 200 );
            var car = new Car("8JR545800Q", 495787123, "Toyota", "2020", "Camry", Color.Black, BodyType.Sedan, EngineType.Combustion, 20000, 80, 200);
            var motorbike = new Motorbike("7294J545809Q", 12368783, "Ducati", "2020", "Panigale", Color.Red, BodyType.Unknown, EngineType.Combustion, 1500, 130, 300);
            var bus = new Bus("8JR523800Q", 495787783, "School Bus", "2020", "Type C", Color.Yellow, BodyType.SchoolBus, EngineType.Combustion, 41560, 100, 200);

            Console.WriteLine(truck.GetInfo());
            Console.WriteLine(car.GetInfo());
            Console.WriteLine(motorbike.GetInfo());
            Console.WriteLine(bus.GetInfo());

        }
    }
}