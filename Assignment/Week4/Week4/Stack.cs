using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public class Stack
    {
        private const int Size = 100;
        private int position;

        object[] items = new object[Size];
        public void Push(object obj)
        {
            items[position++] = obj;
        }

        public object Pop()
        {
            return items[--position];
        }

        public void Display()
        {
            for(int i = 0; i < position; i++) {
                Console.WriteLine(items[i]);
            }
        }
    }
}
