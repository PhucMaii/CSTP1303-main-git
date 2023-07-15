using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tests.Models.TitleModels;

namespace Tests.Models
{
    public abstract class Contacts
    {
        protected string Name { get; set; }
        protected string Address;
        protected Dictionary<_title, ContactDepartment> ContactList;

        public Contacts(string name, string address) 
        {
            Name = name;
            Address = address;
            ContactList = new Dictionary<_title, ContactDepartment>();
        }

        public void AddDepartmentContact(ContactDepartment contactInfo) 
        {
            ContactList.Add(contactInfo.Department, contactInfo);
        }
        public void RemoveDepartmentContact(_title department) 
        {
            if (ContactList.ContainsKey(department))
            {
                ContactList.Remove(department);
            } else
            {
                throw new ArgumentException("Contact Department couldn't found");
            }
        }

        public void DisplayContactList()
        {
            Console.WriteLine("Contact List:");
            foreach(KeyValuePair<_title, ContactDepartment> contact in ContactList)
            {
                Console.WriteLine($"{contact.Key} - Email: {contact.Value.Email}; Phone Number: {contact.Value.Phone}"); 
            }
        }
        public abstract void Display();
    }
}
