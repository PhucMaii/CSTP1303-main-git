using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Vehicle<TVehicleType, TEngine, TBody> 
    {
        protected TVehicleType type;
        private TEngine engine;
        private TBody body;

        public Vehicle(TVehicleType t, TEngine e, TBody b) 
        {
            this.type = t;  
            this.engine = e;
            this.body = b;
        }

        public void SetEngine(TEngine e)
        {
            this.engine = e;
        }

        public TEngine GetEngine() 
        {
            return this.engine;
        }

        public void SetType(TVehicleType t)
        {
            this.type = t;
        }

        public TVehicleType GetVehicleType()
        {
            return this.type;
        }

        public void SetBody(TBody b)
        {
            this.body = b;
        }

        public TBody GetBody()
        {
            return this.body;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Vehicle Type: {this.GetVehicleType()}, Body: {this.GetBody()}, Engine: {this.GetEngine()}");
        }
    }
}
