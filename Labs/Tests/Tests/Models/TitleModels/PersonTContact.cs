using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Models.TitleModels
{
    public class PersonTitleContact : Contact
    {
        private _title Title;

        public PersonTitleContact(string email, string phoneNumber, _title title) : base(email, phoneNumber)
        {
            Title = title;
        }
    }
}
