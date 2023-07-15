using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Models.TitleModels;

namespace Tests.Models
{
    public class Company
    {
        private string name;
        private string address;
        private Dictionary<string, DepartmentContact> DepartmentContacts;
        private Dictionary<string, Person> Employees;
        
    }
}
