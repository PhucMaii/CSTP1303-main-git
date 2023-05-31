﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Truck : Vehicle
    {
        public Truck(string VIN, int licenseNumber, string brand, string make, string model, Color color, BodyType bodyType, EngineType engineType, float dashboardMileage, float speed,
                    float maximumSpeed) : base(VIN, licenseNumber, brand, make, model, color, bodyType, engineType, dashboardMileage, speed,
                    maximumSpeed)
        {
            this.numberOfWheels = 4;
            this.numberOfDoors = 2;
        }
    }
}