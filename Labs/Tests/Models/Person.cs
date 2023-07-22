using Abstractions;
using ContactStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person : Contact, IPerson
    {
        public string EmailAddress { get;}    
        public Person(string id, string name, string email) : base(id, name) 
        {
            EmailAddress = email;
        }
    }

}
