using Assignment4;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Vehicle
    {
        private string VIN;
        private int licenseNumber;
        private string brand;
        private string make;
        private string model;
        private BodyType bodyType;
        private Color color;
        private EngineType engineType;
        private float dashboardMileage;
        private float speed;
        private float maximumSpeed;
        protected int numberOfWheels;
        protected int numberOfDoors;


        public Vehicle(string VIN, int licenseNumber, string brand, string make, string model, Color color, BodyType bodyType, EngineType engineType, float dashboardMileage, float speed,
             float maximumSpeed)
        {
            this.VIN = VIN;
            this.licenseNumber = licenseNumber;
            this.brand = brand;
            this.make = make;
            this.model = model;
            this.color = color;
            this.bodyType = bodyType;   
            this.engineType = engineType;
            this.dashboardMileage = dashboardMileage;
            this.speed = speed;
            this.maximumSpeed = maximumSpeed;

        }

        public string GetInfo()
        {
            return $"VIN: {this.GetVIN()}\tLicenseNumber: {this.GetLicenseNumber()}\tBrand name: {this.GetBrand()}\n" +
                $"Make: {this.GetMake()}\tModel: {this.GetModel()}\tColor: {this.GetColor()}\n" +
                $"Body Type: {this.GetBodyType()}\tEngine Type: {this.GetEngineType()}\tDashboard Mileage: {this.GetDashboardMileage()}\n" +
                $"Speed: {this.GetSpeed()}km/h\tMaximum Speed: {this.GetMaximumSpeed()}km/h\tWheels: {this.numberOfWheels}\n" +
                $"Number of Doors: {this.numberOfDoors}\n-------------------------------------------------------------";
        }

        public void SetVIN(string vin)
        {
            this.VIN = vin;
        }

        public string GetVIN()
        {
            return this.VIN;
        }

        public void SetLicenseNumber(int licenseNum)
        {
            this.licenseNumber = licenseNum;
        }

        public int GetLicenseNumber() 
        { 
            return this.licenseNumber;
        }

        public void SetBrand(string brand) 
        { 
        
            this.brand = brand;
        }

        public string GetBrand()
        {
            return this.brand;
        }

        public void SetMake(string make)
        {
            this.make = make;
        }

        public string GetMake()
        {
            return this.make;
        }

        public void SetDashboardMileage(float dashboardMileage)
        {
            this.dashboardMileage = dashboardMileage;
        }

        public float GetDashboardMileage()
        {
            return this.dashboardMileage;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }

        public string GetModel()
        {
            return this.model;

        }
        public void SetColor(Color color)
        {
            this.color = color;
        }

        public Color GetColor()
        {
            return this.color;

        }

        public void SetBodyType(BodyType bodyType)
        {
            this.bodyType = bodyType;
        }

        public BodyType GetBodyType()
        {
            return this.bodyType;
        }

        public void SetEngineType(EngineType engineType)
        {
            this.engineType = engineType;
        }

        public EngineType GetEngineType()
        {

            return this.engineType;
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }

        public float GetSpeed()
        {
            return this.speed;
        }

        public void SetMaxSpeed(float maxSpeed)
        {
            this.maximumSpeed = maxSpeed;
        }

        public float GetMaximumSpeed()
        {
            return this.maximumSpeed;
        }
    }

}