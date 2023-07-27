using Abstractions;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;

namespace ContactStorageDiskService
{

    public class Storage : IStorage
    {
        public IContact[] contacts { get; set; }
        private int size;
        private int growthFactor;
        private int counter;

        public Storage(int size, int growthFactor)
        {
            this.size = size;
            this.growthFactor = growthFactor;
            this.contacts = new IContact[size];
            this.counter = 0;
        }

        public void Add(ICompany company)
        {
            if(counter >= size)
            {
                ExpandContacts();
            }
            contacts[counter++] = company;

        }

        public void Add(IPerson person)
        {
            if (counter >= size)
            {
                ExpandContacts();
            }
            contacts[counter++] = person;
        }

        public void DeleteCompany(int id)
        {
            ICompany deleteCompany = GetCompanyById(id);
            int companyIndex = Array.IndexOf(contacts, deleteCompany);
            if(companyIndex >= 0 )
            {
                IContact[] newContacts = new IContact[size];
                
                // copy all elements before the remove item;
                for(int i = 0; i < companyIndex; ++i)
                {
                    newContacts[i] = contacts[i];
                }

                // copy all elements after the remove item;
                for(int i = companyIndex + 1; i < size; ++i)
                {
                    newContacts[i - 1] = contacts[i];
                }

                contacts = newContacts;
                --counter;

            }
            else
            {
                throw new Exception("Company couldn't be found in Contact List");
            }
        }

        public void DeletePerson(int id)
        {
            IPerson deletePerson = GetPersonById(id);
            int personIndex = Array.IndexOf(contacts, deletePerson);

            if (personIndex >= 0)
            {
                IContact[] newContacts = new IContact[size];

                // copy all elements before the remove item;
                for (int i = 0; i < personIndex; ++i)
                {
                    newContacts[i] = contacts[i];
                }

                // copy all elements after the remove item;
                for (int i = personIndex + 1; i < size; ++i)
                {
                    newContacts[i - 1] = contacts[i];
                }

                contacts = newContacts;
                --counter;
            }
            else
            {
                throw new Exception("Company couldn't be found in Contact List");
            }
        }

        public ICompany GetCompanyById(int id)
        {
            foreach(var contact in contacts)
            {
                if(contact.Id == id)
                {
                    ICompany company = contact as ICompany;
                    if (company != null)
                    {
                        return (ICompany)contact;
                    } 
                    else 
                    {
                        throw new Exception(" Company Id Could Not Found");
                    }
                } 
            }

            throw new Exception("Id Could Not Found");
        }

        public IPerson GetPersonById(int id)
        {
            foreach (var contact in contacts)
            {
                if (contact.Id == id)
                {
                    IPerson person = contact as IPerson;
                    if (person != null)
                    {
                        return (IPerson)contact;
                    }
                    else
                    {
                        throw new Exception("Person Id Could Not Found");
                    }
                }
            }

            throw new Exception("Id Could Not Found");
        }

        public ICompany GetCompanyByName(string name)
        {
            foreach (var contact in contacts)
            {
                if (contact.Name == name)
                {
                    ICompany company = contact as ICompany;
                    if (company != null)
                    {
                        return (ICompany)contact;
                    }
                    else
                    {
                        throw new Exception(" Company Name Could Not Found");
                    }
                }
            }

            throw new Exception("Name Could Not Found");
        }

        public IPerson GetPersonByName(string name)
        {
            foreach (var contact in contacts)
            {
                if (contact.Name == name)
                {
                    IPerson person = contact as IPerson;
                    if (person != null)
                    {
                        return (IPerson)contact;
                    }
                    else
                    {
                        throw new Exception("Person Name Could Not Found");
                    }
                }
            }

            throw new Exception("Name Could Not Found");
        }

        public void UpdateName(int id, string name)
        {
            IPerson person = GetPersonById(id);
            person.Name = name;

        }
        
        public void UpdateDepartmentContact(int id, string dName, string email = "None", string phone = "None")
        {
            ICompany company = GetCompanyById(id);
            var department = company.GetDepartment(dName);
            
            if(department != null)
            {
                if(email != "None")
                {
                    department.Email = email;
                }
                if(phone != "None") 
                {
                    department.Phone = phone;
                }
            } else
            {
                throw new Exception("Department Could Not Found");
            }
        }

        public void UpdatePersonEmail(int id, string email)
        {
            IPerson person= GetPersonById(id);

            person.Email = email;
            
        }
        public void UpdatePersonPhone(int id, string phone)
        {
            IPerson person = GetPersonById(id);

            person.Phone = phone;

        }

        public string Display()
        {
            string result = "";
            foreach(IContact contact in contacts)
            {
                IPerson person = contact as IPerson;
                if (person != null)
                {
                    result += $"Person Name: {person.Name}\tPerson Email: {person.Email}\tPerson Phone Number: {person.Phone}\n";
                }
                else
                {
                    result += $"Company Name: {contact.Name}\n";
                }
            }
            return result;
        }
        public void ExpandContacts()
        {
            int newSize = size * growthFactor;
            IContact[] newContacts = new IContact[newSize];
            
            for(int i = 0; i < size; i++)
            {
                newContacts[i] = contacts[i];
            }

            contacts = newContacts;
        }
    }
}
