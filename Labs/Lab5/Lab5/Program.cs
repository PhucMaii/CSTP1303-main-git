using System;

namespace Lab5
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddTail(new LinkedListNode<int>(56));
            list.AddTail(new LinkedListNode<int>(24));
            list.AddTail(new LinkedListNode<int>(101));




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