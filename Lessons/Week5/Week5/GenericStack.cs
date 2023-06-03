using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class GenericStack<T>
    {
        private int _size;
        private int _position;
        private T[] data = new T[100];
/*        public GenericStack()
        {
            this._size = 5;
        }*/
        public GenericStack(int size) 
        {
            _size = size; ;
            data = new T[_size];
        }
        public void Push(T item)
        {
            data[++_position] = item;

        }

        public T Pop() 
        {
            return data[--_position];
        }
    }
}
