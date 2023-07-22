using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tests.Models.TitleModels;

namespace Tests.Models
{
    public class Person : Contacts
    {
        private int Age;
        public Person(string name, string address, int age) : base(name, address)
        {
            Age = age;
        }

        public override void Display()
        {
            Console.WriteLine("*************");
            Console.WriteLine("Person Details:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Age: " + Age);
            DisplayContactList();
            Console.WriteLine("*************");
        }
    }
}
