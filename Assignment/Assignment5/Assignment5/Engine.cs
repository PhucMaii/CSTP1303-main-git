using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Engine
    {
        private int capacity;
        private int horserPower;

        public Engine(int capacity, int horserPower)
        {
            this.capacity = capacity;
            this.horserPower = horserPower; 
        }

        public string GetInfo()
        {
            return $"Capacity: {capacity}, Horse Power: {horserPower}";
        }
    }
}
