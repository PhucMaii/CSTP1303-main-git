using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Department : IDepartment
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; } 

        public Department(string name ,string email, string phone) 
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }
    }
}
