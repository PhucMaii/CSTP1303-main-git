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
        void UpdateName(int id, string name);


        // Company Methods
        void Add(ICompany company);
        ICompany GetCompanyById(int id);
        ICompany GetCompanyByName(string name);
        void UpdateDepartmentContact(int id, string department, string email = "None", string phone = "None");

        void DeleteCompany(int id);


        // Person Method
        void Add(IPerson person);
        IPerson GetPersonById(int id);
        IPerson GetPersonByName(string name);
        void UpdatePersonEmail(int id, string email);
        void UpdatePersonPhone(int id, string phone);   
        void DeletePerson(int id);
    }
}
