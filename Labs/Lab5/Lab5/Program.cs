using System;

namespace Lab5
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddTail(new LinkedListNode<int>(85));
            list.AddTail(new LinkedListNode<int>(19));
            list.AddTail(new LinkedListNode<int>(20));
            list.AddTail(new LinkedListNode<int>(1));
            list.AddTail(new LinkedListNode<int>(38));




            // List before reversal
            Console.WriteLine("Given linked list ");
            list.PrintList();

            // Reverse the list
            list.ReverseLinkedList();

            // List after reversal
            Console.WriteLine("Reversed linked list ");
            list.PrintList();
        }
    }
}