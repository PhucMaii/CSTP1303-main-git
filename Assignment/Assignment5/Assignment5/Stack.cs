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
    public class Stack<T>
    {
        private int size;
        private int position;
        private T[] items;


        public Stack(int size)
        {
            this.size = size;
            items = new T[size];
        }

        public T Push(T item)
        {
            return items[position++] = item;
        }

        public T Pop()
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
                if (i == position - 1)
                {
                    Console.WriteLine(items[i]);

                }
            }
        }
    }
}
