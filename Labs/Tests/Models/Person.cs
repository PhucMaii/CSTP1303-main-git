using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person : Contact, IPerson
    {
        public string Email { get; set; }    
        public  string Phone { get; set; }
        public Person(string id, string name, string email, string phone) : base(id, name) 
        {
            Email = email;
            Phone = phone;
        }


    }

}
