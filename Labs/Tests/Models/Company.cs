


namespace Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Company : ICompany
    {
        public string Id { get;  }
        public string Name { get; set; }

        public Company(string id, string name)
        {
            if(string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentNullException("Company id is required");
            }
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Company name is required");
            }
            Id = id;
            Name = name;
        }

    }
}
