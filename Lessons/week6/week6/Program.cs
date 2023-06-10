using System;

namespace week6
{
    public class Program
    {
        static void Main(string[] args) 
        {
            BTNode<int> node1 = new BTNode<int>() { Data = 12 };
            BTNode<int> node2= new BTNode<int>() { Data = 13 };
            BTNode<int> node3 = new BTNode<int>() { Data = 34 };

            node1.Left = node2;
            node1.Right = node3;

            var testDelegate = new DelegateExample();

            testDelegate.TestSimpleDelegate();

        }
    }
}