using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Contact : IContact
    {
        public int Id { get; }
        public string Name { get; set; }

        public Contact(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
