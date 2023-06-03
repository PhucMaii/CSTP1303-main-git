using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public class MallardDuck: Duck
    {
        public MallardDuck(int id, string name) : base(id, name)
        {
            age = 2;
        }

        public override int FieldId => this.GetId() +  this.age;
    }
}

