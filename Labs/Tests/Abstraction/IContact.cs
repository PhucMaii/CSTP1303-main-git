using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface IContact
    {
        public int Id { get; }
        public string Name { get; set; }
    }
}
