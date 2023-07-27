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
        private Dictionary<int, IPerson> employees;
        public Company(int id, string name ) : base( id, name ) 
        {
            departmentContacts = new Dictionary<string, IDepartment>();
            employees = new Dictionary<int, IPerson>();
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

        public void AddEmployee(IPerson employee)
        {
            employees.Add(employee.Id, employee);
        }

        public void RemoveEmployee(int employeeId)
        {
            employees.Remove(employeeId);
        }

        public IPerson GetEmployee(int employeeId)
        {
            return employees[employeeId];
        }


    }
}
