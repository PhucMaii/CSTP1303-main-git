using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace week6
{
    delegate int TransformInt(int x);
    public class DelegateExample
    {
        public void TestSimpleDelegate()
        {
            TransformInt transform1 = this.Square;
            int result1 = transform1(5);

            Console.WriteLine(result1);
            TransformInt transform2 = this.Square;

        }

        public int Square(int side)
        {
            return side * side;
        }


        public int[] TransformArray(int[] values, TransformInt transformer)
        {
            var result = new int[values.Length];
            for(int i = 0; i < values.Length; i++)
            {
                result[i] = transformer(values[i]);
            }

            return result;
        }
    }

}
