using System;
using ContactStorageDiskService;
using Models;
namespace Tests 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Storage store = new Storage(3, 2);

            Person p1 = new("1", "Bin", "bin@gmail.com", "111-111-1111");
            Person p2 = new Person("2", "John", "john@gmail.com", "222-222-2222");
            Person p3 = new Person("3", "Michael", "michael@gmail.com", "333-333-3333");
            Company c1 = new Company("4", "MyCompany");

            store.Add(p1);
            store.Add(p2);
            store.Add(c1 );
            store.Delete(p2);
            store.Add(p3);



            for(int i = 0; i < store.contacts.Length; ++i)
            {
                if (store.contacts[i] != null)
                {
                    Console.WriteLine(store.contacts[i].Name);

                }
            }

            store.GetCompanyById("4");
        }

 
    }

}
