using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface ICompany : IContact
    {
        public string _id { get; }
        public string _name { get; set; }
    }
}
