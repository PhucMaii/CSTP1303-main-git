using System;

namespace Lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var userArr = new User[10];

            for (int i = 0; i < userArr.Length; i++)
            {
                int userId = i + 1;
                userArr[i] = new User()
                {
                    id = userId,
                    name = "placeholder" + userId
                };
            }
            Program program = new Program();
            program.PrintUserArray(userArr);

        }

        public void PrintUserArray(User[] users)
        {
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine($"id: {users[i].id}, name: {users[i].name}");
            }
        }

    }
}