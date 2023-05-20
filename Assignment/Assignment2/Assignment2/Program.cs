using System;
using System.Xml.Linq;

namespace Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var userArr = new User[100];
            
            Program program = new Program();

            // For testing
            program.addUser(userArr, "Bin");
            program.addUser(userArr, "Test1");
            program.addUser(userArr, "Test2");
            program.addUser(userArr, "Test3"); 
            program.addUser(userArr, "Test4");


            program.deleteUserById(userArr, 2);
            program.deleteUserByName(userArr, "Binn");

            program.getUserById(userArr, 1);
            program.getUserByName(userArr, "Test4");

            program.PrintUser(userArr);
        }

        public void PrintUser(User[] userArr)
        {   
            for(int i = 0; i < userArr.Length; i++)
            {
                if (userArr[i] != null)
                {
                    Console.WriteLine($"{userArr[i].name}");
                }

            }
        }
        public void addUser(User[] userArr, string name)
        {
            for(int i = 0; i < userArr.Length; i++)
            {
                if (userArr[i] == null)
                {
                    userArr[i] = new User()
                    {
                        id = i,
                        name = name 
                    };
                    return;
                }
            }
        }

        public void getUserById(User[] userArr, int id)
        {
            if (userArr[id] == null)
            {
                Console.WriteLine("No User Found!!!");

            } else
            {
                Console.WriteLine($"id: {userArr[id].id}, name: {userArr[id].name}");

            }
        }
        public void getUserByName(User[] userArr, string name)
        {
            for (int i = 0; i < userArr.Length; i++)
            {
                if (userArr[i] != null && userArr[i].name == name)
                {
                    Console.WriteLine($"id: {userArr[i].id}, name: {userArr[i].name}");
                    return;
                }

            }
            Console.WriteLine("No User Found!!!");

        }

        public void deleteUserById(User[] userArr, int id)
        {
            if (userArr[id] == null)
            {
                Console.WriteLine("Invalid ID");

            }
            else
            {
                Console.WriteLine($"Delete User {userArr[id].name} Successfullly");
                userArr[id] = null;

            }
        }

        public void deleteUserByName(User[] userArr, string name)
        {
            for (int i = 0; i < userArr.Length; i++)
            {
                if (userArr[i] != null && userArr[i].name == name)
                {
                    Console.WriteLine($"Delete User {userArr[i].name} Successfully");
                    userArr[i] = null;
                    return;
                }

            }
            Console.WriteLine($"No User Found with name: {name} !!!");
        }  
    }
}