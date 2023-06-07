using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment5
{
    public class Car<TVehicleType, TEngine, TBody> : Vehicle<TVehicleType, TEngine, TBody>
    {
        public Car(TVehicleType t, TEngine e, TBody b) : base(t, e, b)
        {
        }


    }
}

