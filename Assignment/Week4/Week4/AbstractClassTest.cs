using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public class AbstractClassTest
    {
        public void Test1()
        {
            var mallard1 = new MallardDuck(14, "mallard");
            this.Display1(mallard1);
        }
        public void Display1(Duck duck)
        {
            Console.WriteLine($"Duck: {duck.GetInfo()}");
        }
    }
}
