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
        public string Id { get; }
        public string Name { get; set; }

        public Contact(string id, string name)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentNullException("Company id is required");
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Company name is required");
            }
            Id = id;
            Name = name;
        }

    }
}
