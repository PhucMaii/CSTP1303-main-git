using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public abstract class Duck
    {
        private int id;
        private string name;
        protected int age;

        public Duck(int id, string name)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "id should be greater than zero");
            }
            if (string.IsNullOrWhiteSpace(name)) // invalid input: "    " or null or ""
            {
                throw new ArgumentNullException(nameof(name), "name cannot be null or whitespace");
            }
            this.id = id;
            this.name = name;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetInfo()
        {
            return $"duck: {this.name} - {this.id}";
        }

        /* 
         * a virtual function can be overriden by subclasses
         */
        public virtual void Fly()
        {
            Console.WriteLine($"{this.id} - {this.name} flying...");
        }

        public abstract int FieldId
        {
            get;
        }
    }
}
