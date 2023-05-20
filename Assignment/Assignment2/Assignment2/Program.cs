using Microsoft.VisualBasic.FileIO;
using System;
using System.Transactions;
using System.Xml.Linq;

namespace Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var userArr = new User[100];
            
            Program program = new Program();


            int option = 0;
            Console.WriteLine("Welcome to our program, please enter a number below:");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Get User By Id");
            Console.WriteLine("3. Get User By Name");
            Console.WriteLine("4. Delete User By Id");
            Console.WriteLine("5. Delete User By Name");
            Console.WriteLine("6. Print All Users");

            bool isContinue = false;

            while(!isContinue)
            {
                Console.WriteLine("Enter a Number!!!");

                string input = Console.ReadLine();
                int.TryParse(input, out option);


                switch (option)
                {
                    case 1:
                        Console.WriteLine("You choose to add User! Please enter user name");
                        string userName = Console.ReadLine();
                        program.addUser(userArr, userName);
                        Console.WriteLine("Add User Successfully!");
                        break;
                    case 2:
                        Console.WriteLine("You choose to get user by Id! Please enter user id");
                        string userIdStr = Console.ReadLine();
                        int.TryParse(userIdStr, out int userId);
                        program.getUserById(userArr, userId);
                        break;
                    case 3:
                        Console.WriteLine("You choose to get user by name! Please enter user name");
                        string name = Console.ReadLine();
                        program.getUserByName(userArr, name);
                        break;
                    case 4:
                        Console.WriteLine("You choose to delete user by id! Please enter user id");
                        string idStr = Console.ReadLine();
                        int.TryParse(idStr, out int id);
                        program.deleteUserById(userArr, id);
                        break;
                    case 5:
                        Console.WriteLine("You choose to delete user by name! Please enter user name");
                        string deleteName = Console.ReadLine();
                        program.deleteUserByName(userArr, deleteName);
                        break;
                    case 6:
                        Console.WriteLine("You choose to print all users");
                        program.PrintUser(userArr);
                        break;
                    default:
                        Console.WriteLine("You choose to exit!");
                        isContinue = true;
                        break;
                }
            }
        
        }

        public void PrintUser(User[] userArr)
        {   
            for(int i = 0; i < userArr.Length; i++)
            {
                if (userArr[i] != null)
                {
                    Console.WriteLine($"{userArr[i].id}. {userArr[i].name}");
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