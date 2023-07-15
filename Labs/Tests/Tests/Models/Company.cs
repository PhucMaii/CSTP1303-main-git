using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Models.TitleModels;

namespace Tests.Models
{
    public class Company : Contacts
    {
        private Dictionary<string, Person> Employees;

        public Company(string name, string address) : base(name, address)
        {
        }

        public override void Display()
        {
            Console.WriteLine("*************");
            Console.WriteLine("Person Details:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            DisplayContactList();
            Console.WriteLine("*************");
        }
    }
}
