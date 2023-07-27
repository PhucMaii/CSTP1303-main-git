using System;
using System.Runtime.CompilerServices;
using System.Linq;
using Abstractions;
using ContactStorageDiskService;
using Models;
namespace Tests 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Storage store = new Storage(3, 2);


            for(int i = 0; i < store.contacts.Length; ++i)
            {
                if (store.contacts[i] != null)
                {
                    Console.WriteLine(store.contacts[i].Name);

                }
            }

            Console.WriteLine("===================== WELCOME TO OUR CONTACT MANAGER APPLICATION =====================");
            Console.WriteLine("Press a number (0 - 10) to get your job done with features below:\n" +
                "0 - Exit The Program\n" +
                "10 - Display All Contacts\n" +
                "===================== Person Methods ===================== \n" +
                "1 - Add A Person\n" +
                "2 - Retrieve A Person\n" +
                "3 - Update A Person\n" +
                "4 - Delete A Person\n" +
                "===================== Company Methods =====================\n" +
                "5 - Add A Company\n" +
                "6 - Retrieve A Company\n" +
                "7 - Delete A Company\n" +
                "8 - Manipulate Department Contacts\n" +
                "9 - Manipulate Employee Contacts\n");

            // Id tracker for storage, whenever the person or company is added, id is increased by one and will be attached to the next contact.
            int id = 1;
            
            // user option
            int option = 1;
 
            while(option > 0 && option < 11)
            {
                Console.Write("=> ");
                
                string userChoice = Console.ReadLine();
                int.TryParse(userChoice, out option);
                switch (userChoice)
                {
                    case "0":
                        Console.WriteLine("Thank you for using our application. Have a nice day");
                        break;
                    case "1":
                        Console.WriteLine("You Choose To Add A Person Into Contact List. Please Enter Their Name, Email, and Phone Number and separate them by press Enter");
                        string personName = Console.ReadLine();
                        string personEmail = Console.ReadLine();
                        string personPhone = Console.ReadLine();

                        Person newPerson = new Person(id, personName, personEmail, personPhone);
                        store.Add(newPerson);
                        Console.WriteLine($"Successfully Add {personName} Into Contact List");
                        ++id;
                        break;
                    case "2":
                        Console.WriteLine("You Choose To Access A Person In Contact List. Please Enter Their Id");
                        int RPersonId;
                        string RPersonIdInput = Console.ReadLine();
                        int.TryParse(RPersonIdInput, out RPersonId);
                        IPerson retrievePerson = store.GetPersonById(RPersonId);
                        Console.WriteLine($"Name: {retrievePerson.Name}\tEmail: {retrievePerson.Email}\tPhone Number: {retrievePerson.Phone}");
                        break;
                    case "3":
                        Console.WriteLine("You Choose To Update A Person Contact In Contact List. Please Enter Their Id and New Email or New Phone Number");
                        int UPersonId;

                        string UPersonIdInput = Console.ReadLine();
                        int.TryParse(UPersonIdInput, out UPersonId);

                        string updatedValue = Console.ReadLine();

                        if (updatedValue.Contains('@'))
                        {
                            store.UpdatePersonEmail(UPersonId, updatedValue);
                        }
                        else
                        {
                            store.UpdatePersonPhone(UPersonId, updatedValue);

                        }
                        Console.WriteLine("Succesfully Updated Person Email");
                        break;
                    case "4":
                        Console.WriteLine("You Choose To Delete A Person Contact In Contact List. Please Enter Their Id");
                        int DPersonId;

                        string DPersonIdInput = Console.ReadLine();
                        int.TryParse(DPersonIdInput, out DPersonId);
                        store.DeletePerson(DPersonId);
                        Console.WriteLine("Succesfully Deleted A Person Contact");
                        break;
                    case "5":
                        Console.WriteLine("You Choose To Add A Company Into Contact List. Please Enter Their Name");
                        string companyName = Console.ReadLine();

                        Company newCompany = new Company(id, companyName);
                        store.Add(newCompany);
                        Console.WriteLine($"Successfully Add {companyName} Into Contact List");
                        ++id;
                        break;
                    case "6":
                        Console.WriteLine("You Choose To Access A Company In Contact List. Please Enter Their Id");
                        int RCompanyId;
                        string RCompIdInput = Console.ReadLine();
                        int.TryParse(RCompIdInput, out RCompanyId);
                        ICompany retrieveCompany = store.GetCompanyById(RCompanyId);
                        Console.WriteLine($"Name: {retrieveCompany.Name}");
                        break;
                    case "7":
                        Console.WriteLine("You Choose To Delete A Company Contact In Contact List. Please Enter Their Id");
                        int DCompanyId;

                        string DCompanyIdInput = Console.ReadLine();
                        int.TryParse(DCompanyIdInput, out DCompanyId);
                        store.DeletePerson(DCompanyId);
                        Console.WriteLine("Succesfully Deleted A Company Contact");
                        break;

                    // Manipulate Department Array in Company
                    case "8":
                        Console.WriteLine("You Choose To Manipulate Company Department Contacts In Contact List. Please Enter Company Id First");
                        int CRUDDCompanyId;

                        string CRUDDCompanyIdInput = Console.ReadLine();
                        int.TryParse(CRUDDCompanyIdInput, out CRUDDCompanyId);
                        ICompany DCompany = store.GetCompanyById(CRUDDCompanyId);

                        int departmentMethod = 1;
                        // Nested switch cases
                        while(departmentMethod > 0 && departmentMethod < 4)
                        {
                            Console.Write("Department Method >> ");
                            string dUserInput = Console.ReadLine();
                            int.TryParse(dUserInput, out departmentMethod);

                            switch(dUserInput)
                            {
                                case "0":
                                    Console.WriteLine("EXIT");
                                    break;
                                case "1":
                                    Console.WriteLine("ADD DEPARTMENT - Enter Department Name, Email, Phone Number");
                                    string CNameInput = Console.ReadLine();
                                    string CEmailInput = Console.ReadLine(); 
                                    string CPhoneInput = Console.ReadLine();

                                    IDepartment newDepartment = new Department(CNameInput, CEmailInput, CPhoneInput);
                                    DCompany.AddDepartment(newDepartment);
                                    Console.WriteLine($"Successfully Add {newDepartment.Name} Into Department List");
                                    break;
                                case "2":
                                    Console.WriteLine("REMOVE DEPARTMENT - Enter Department Name");
                                    string DNameInput = Console.ReadLine();

                                    DCompany.RemoveDepartment(DNameInput);
                                    Console.WriteLine($"Successfully Remove {DNameInput} Into Department List");
                                    break;
                                case "3":
                                    Console.WriteLine("RETRIEVE DEPARTMENT - Enter Department Name");
                                    string RNameInput = Console.ReadLine();
                                    IDepartment department = DCompany.GetDepartment(RNameInput);
                                    Console.WriteLine($"Department Name: {department.Name}\tDepartment Email: {department.Email}\tDepartment Phone Number: {department.Phone}");
                                    break;
                                default:
                                    throw new Exception("Invalid Action");

                            }
                        }

                        break;
                    // Manipulate Employee List in Company
                    case "9":
                        Console.WriteLine("You Choose To Manipulate Company Department Contacts In Contact List. Please Enter Company Id First");
                        int CRUDECompanyId;

                        string CRUDECompanyIdInput = Console.ReadLine();
                        int.TryParse(CRUDECompanyIdInput, out CRUDECompanyId);
                        ICompany ECompany = store.GetCompanyById(CRUDECompanyId);

                        int employeeMethod = 0;
                        while (employeeMethod > 0 && employeeMethod < 4)
                        {
                            Console.Write("Employee Method >> ");
                            string eUserInput = Console.ReadLine();
                            int.TryParse(eUserInput, out employeeMethod);

                            // Get Employee ID to find the Person Object from Store
                            Console.WriteLine("Enter Employee ID To Continue");
                            int eID;
                            string eIdInput = Console.ReadLine();
                            int.TryParse(eIdInput, out eID);
                            IPerson employee = store.GetPersonById(eID);

                            switch (eUserInput)
                            {
                               
                                case "0":
                                    Console.WriteLine("EXIT");
                                    break;
                                case "1":
                                    Console.WriteLine("ADD EMPLOYEE");
                                    ECompany.AddEmployee(employee);
                                    Console.WriteLine($"Successfully Add {employee.Name} Into Department List");
                                    break;
                                case "2":
                                    Console.WriteLine("REMOVE EMPLOYEE");

                                    ECompany.RemoveEmployee(eID);
                                    Console.WriteLine($"Successfully Remove {employee.Name} Into Department List");
                                    break;
                                case "3":
                                    Console.WriteLine("RETRIEVE EMPLOYEE");
                                    ECompany.GetEmployee(eID);
                                    Console.WriteLine($"Department Name: {employee.Name}\tDepartment Email: {employee.Email}\tDepartment Phone Number: {employee.Phone}");
                                    break;
                                default:
                                    throw new Exception("Invalid Action");

                            }
                        }

                        break;
                    case "10":
                        Console.WriteLine(store.Display());
                        break;

                    default:
                        throw new Exception("Invalid Action");
                }
            }
           
        }

 
    }

}
