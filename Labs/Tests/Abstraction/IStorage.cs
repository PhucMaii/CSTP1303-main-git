using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface IStorage
    {
        void Add(ICompany company);
        ICompany GetCompany();
        void Update(ICompany company);
        void Delete(ICompany company);

        void Add(IPerson person);
        IPerson GetPerson();
        void UpdatePerson(IPerson person);
        void DeletePerson(IPerson person);
    }
}
