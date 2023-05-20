using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Motorbike : Vehicle

    {
        public Motorbike(int id, string name) : base(id, name)
        {
            this.wheels = 2;
        }  
    }
}
