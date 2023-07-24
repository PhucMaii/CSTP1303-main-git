using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface IStorage
    {
        // General Method
        void UpdateName(string id, string name);
        

        // Company Methods
        void Add(ICompany company);
        ICompany GetCompanyById(string id);
        ICompany GetCompanyByName(string name);
        void UpdateDepartmentContact(string id, string department, string email = "None", string phone = "None");

        void Delete(ICompany company);


        // Person Method
        void Add(IPerson person);
        IPerson GetPersonById(string id);
        IPerson GetPersonByName(string name);
        void UpdatePersonContact(string id, string email = "None", string phone = "None");
        void Delete(IPerson person);
    }
}
