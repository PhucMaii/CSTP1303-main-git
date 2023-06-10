using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Body
    {
        private string color;
        private string model;

        public Body(string color, string model)
        {
            this.color = color;
            this.model = model;
        }   

        public string GetInfo()
        {
            return $"Color: {color}, Model: {model}";
        }
    }
}
