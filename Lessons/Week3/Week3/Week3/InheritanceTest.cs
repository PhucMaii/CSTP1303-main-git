using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    public class InheritanceTest
    {
        public void Test1()
        {
            var duck1 = new Duck(12, "a duck");
            var redhead1 = new RedHeadDuck(0, "redhead1", "light");
            var mallard1 = new MallardDuck(14, "mallard");


            this.Display(duck1);
            this.Display(redhead1);
            this.Display(mallard1);

            this.Display2(redhead1);

            Duck duck2 = redhead1; // upcast
            Console.WriteLine(redhead1.ColorTone);

            RedHeadDuck redhead2 = (RedHeadDuck)duck2; // downcast

            // the as operator
            var duck3 = new Duck(2, "Gene");
            MallardDuck mallard2 = duck3 as MallardDuck;

            // the is operator
            if(mallard2 is Duck)
            {
                Console.WriteLine("mallard2 is a duck");
            }
        }
        /* if called by passing a subclass it is 
         * automatically converting the subclass to base class */
        public void Display(Duck duck)
        {
            Console.WriteLine($"Duck: {duck.GetInfo()}");
        }

        public void Display2(RedHeadDuck redhead)
        {
            Console.WriteLine($"Duck: {redhead.GetInfo()}");

        }
    }
}
