﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Models.TitleModels;

namespace Abstraction
{
<<<<<<< HEAD:Labs/Tests/Abstraction/ICompany.cs
    public interface ICompany
    {
        public string Id { get; }
        public string Name { get; set; }
=======
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
>>>>>>> 1ae21ffe1d2fcadafe30dc6939bc1d63344e5e14:Labs/Tests/Tests/Models/Company.cs
    }
}
