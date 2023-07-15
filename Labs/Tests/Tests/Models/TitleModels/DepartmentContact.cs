using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Models.TitleModels
{
    public class DepartmentContact : Contact
    {
        private _title Department;

        public DepartmentContact(string email, string phone, _title department) : base(email, phone) 
        {
            Department = department;
        }

    }
}
