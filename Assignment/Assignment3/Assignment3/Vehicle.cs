using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Vehicle
    {
        private string name;
        private int id;
        protected int wheels;
        public Vehicle(int id, string name)
        {
            this.name = name;
            this.id = id;
        }

        public string GetInfo()
        {
            return $"vehicle: {this.name} - {this.id} has {this.wheels}";
        }
    }
}