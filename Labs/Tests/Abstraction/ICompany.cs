using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface ICompany : IContact
    {

        public void AddDepartment(IDepartment department);  
        public void RemoveDepartment(string dName);
        public IDepartment GetDepartment(string dName);

        public void AddEmployee(IPerson person);
        public void RemoveEmployee(int employeeId);
        public IPerson GetEmployee(int employeeId);    
        
    }
}
