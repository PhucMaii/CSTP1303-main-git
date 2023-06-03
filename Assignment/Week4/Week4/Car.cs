using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public class Car
    {
        private Color color;
        public Car(Color color) {
            this.color = color;
        }

        public Color GetColor()
        {
            return color;
        }
    }
}
