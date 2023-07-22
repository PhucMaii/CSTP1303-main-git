using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public interface ICompany
    {
        public string Id { get; }
        public string Name { get; set; }
    }
}
