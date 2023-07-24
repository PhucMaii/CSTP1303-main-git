using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractions;

namespace Models
{

   
    public class Company : Contact, ICompany
    {
        private Dictionary<string, IDepartment> departmentContacts;
        public Company(string id, string name ) : base( id, name ) 
        {
            departmentContacts = new Dictionary<string, IDepartment>();
        }  

        public void AddDepartment( IDepartment department )
        {
            departmentContacts.Add(department.Name, department);
        }

        public void RemoveDepartment(string dName)
        {
            departmentContacts.Remove( dName );
        }

        public IDepartment GetDepartment(string dName)
        {
            return departmentContacts[dName];
        }
    }
}
