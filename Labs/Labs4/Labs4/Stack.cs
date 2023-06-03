using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Labs4
{
    public class Stack
    {
        private int size;
        private int position;
        private object[] items;


        public Stack(int size) 
        {
            this.size = size;
            items = new object[size];
        }

        public object Push(object item)
        {
            return items[position++] = item;
        }

        public object Pop()
        {
            return items[--position];
        }

        public void Display()
        {
            for (int i = 0; i < position; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public void Peak()
        {
            for (int i = 0; i < position; i++)
            {
                if(i == position - 1)
                {
                    Console.WriteLine(items[i]);

                }
            }
        }
    }
}
