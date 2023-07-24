using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface IPerson : IContact
    {
        public string Email { get; set; }
        public string Phone { get; set; }  
    }
}
