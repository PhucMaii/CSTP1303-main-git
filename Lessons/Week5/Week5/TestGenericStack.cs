using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class TestGenericStack
    {
        public void Test1()
        {
            var stack1 = new GenericStack<int>(100);
            var stack2 = new GenericStack<string>(100);

            
        }

        public void Test2()
        {
            int x = 5;
            int y = 19;

            GenericSwap<int>(ref x, ref y);
        }

        public void GenericSwap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public void Test3()
        {
            var list = new List<int>();
            list.Add(10);
            list.Add(19);
            list.Add(57);

            list.Remove(19);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.ElementAt(i));
            }

            var list2 = new List<int>();

        }

        public void Test_Framework_Dictionary()
        {
            var dicOfCars = new Dictionary<int, int>();

        }
    }
}
