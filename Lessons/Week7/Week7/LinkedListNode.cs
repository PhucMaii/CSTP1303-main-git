using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    public class LinkedListNode<T>
    {
        public T Data { get; set; }

        public LinkedListNode(T data) { this.Data = data; } 
        
        public LinkedList<T> Next { get; set; }
    }
}
