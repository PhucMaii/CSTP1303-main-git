using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    public class LinkedList<T>
    {
        private int count;
        public LinkedListNode<T> Head { get; private set; }
        public LinkedListNode<T> Tail { get; private set; }
        public void AddHead(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = this.Head;

            this.Head = node;

            this.Head.Next = temp;
            this.count++;


        }

        public void AddTail(LinkedListNode<T> node)
        {
            if(this.count == 0)
            {
                this.Head = node;
            } else
            {
                this.Tail.Next = node;
                
            }

            this.Tail = node;
            this.count++;
        }

        public void RemoveHead()
        {
            
            this.Head = this.Head.Next;
            this.count--;

            if(this.count == 0)
            {
                this.Tail = null;
            }
        }

        public bool Remove(T data)
        {
            LinkedListNode<T> current = this.Head;
            LinkedListNode<T> previous = null;

            while(current != null)
            {
                if(current.Data.Equals(data))
                {
                    if(previous != null)
                    {
                        previous.Next = current.Next; 
                        if(current.Next == null)
                        {
                            this.Tail = previous;
                        }
                        this.count--;

                    } else
                    {
                        this.RemoveHead();
                    }
                    return true;
                } 

                previous = current;
                current = current.Next;
            }

            return false;

        }

        public void RemoveTail()
        {

        }
        public static implicit operator LinkedList<T>(LinkedListNode<T> v)
        {
            throw new NotImplementedException();
        }
    }
}
