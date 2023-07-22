using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Models.TitleModels
{
    public class ContactDepartment
    {
        private string _email;
        private string _phone;
        private _title _department;

        public ContactDepartment(string email, string phone, _title department)
        {
            _email = email;
            _phone = phone;
            _department = department;
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public _title Department
        {
            get { return _department; }
            set { _department = value; }    
        }
    }
}
