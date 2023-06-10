using System;

namespace Assignment5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Engine newEngine = new Engine(200, 200);
            var engine = newEngine.GetInfo();
            Body newBody = new Body("red", "SUV");
            var body = newBody.GetInfo();
            var car = new Car<VehicleType, string, string>(VehicleType.Car, engine, body ) ;
            car.GetInfo();

        }
    }
}

