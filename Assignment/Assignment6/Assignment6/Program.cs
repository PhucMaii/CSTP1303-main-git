using System;

namespace Assignment6
{
    public class Program
    {
        public delegate void PrintArray(User[] objArray);
        static public void Display(User[] users)
        {
            for (int i = 0; i < users.Length; ++i)
            {
                Console.WriteLine($"{i}. Name: {users[i].name}\t" +
                    $"Username: {users[i].username}\t" +
                    $"Email: {users[i].email}\n");
            }
        }
        static void Main(string[] args)
        {
            string[] names = { "John", "Smith", "Bin", "Jia", "Adam", "Michael", "Jackson", "Mia", "Aaron", "Benson" };
            
            User[] users = new User[10];

            for (int i = 0; i < 5; i++) 
            {
                RegularUser newUser = new RegularUser(names[i], $"ru{i}", $"{names[i]}@gmail.com");
                users[i] = newUser;
            }

            for (int i = 5; i < 10; i++)
            {
                EliteUser newUser = new EliteUser(names[i], $"ru{i}", $"{names[i]}@gmail.com");
                users[i] = newUser;
            }

            PrintArray display = new PrintArray(Display);
            display(users);
        }
    }
}