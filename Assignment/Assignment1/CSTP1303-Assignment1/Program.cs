using System;
using System.ComponentModel.Design;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args) {
            Program program = new Program();
            var userInput = program.getUserChoice();
            Console.WriteLine($"You picked option {userInput}");
        }

        public int getUserChoice()
        {
            Console.WriteLine("Pick Option Below");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}. Option {i}");
            }
            int option = 0;
            bool isValid = false;

            while(!isValid)
            {
                Console.Write(" ==> ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out option))
                {
                    if (option > 0 && option <= 10)
                    {
                        isValid = true;
                    }
                }

                if(!isValid)
                {
                    Console.WriteLine("InValid Input");
                }
            }
            return option;
        }
    }


}
