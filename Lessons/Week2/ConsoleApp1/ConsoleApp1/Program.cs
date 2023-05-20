using System;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point();
            Point p3 = new Point();

            p1.x = 12;
            p1.y = 10;

            p3.x = 50;
            p3.y = 60;
            Console.WriteLine($"before: {p3.x}, {p3.y}");

            p3 = p1;
            Console.WriteLine($"after: {p3.x}, {p3.y}");

            Program program = new Program();
            p2 = null;
            program.Print(p2);
             
            PointStruct ps1 = new PointStruct();   
            ps1.x = 120;
            ps1.y = 100;

            PointStruct ps2;

            Console.WriteLine($"x: {ps1.x}, {ps1.y}");

            var userArr = new User[10];

            for(int i =  0; i < userArr.Length; i++)
            {
                int userId = i + 1;
                userArr[i] = new User()
                {
                    id = userId,
                    name = "placeholder" + userId
                };
            }    

            program.PrintUserArray(userArr);

            var argPassing = new ArgumentPassing();
            argPassing.RunTest();


            var et = new TryCatch();
            et.RunTest2();

        }

        public void PrintUserArray(User[] users)
        {
            for(int i = 0; i < users.Length ; i++)
            {
                Console.WriteLine($"id: {users[i].id}, name: {users[i].name}");
            }
        }
        public void Print(Point p)
        {   
            if(p == null) 
            { 
                Console.WriteLine("Warning!");
                return;
            }
            Console.WriteLine($"x: {p.x}, {p.y}");

        }

        public void TestCharArrays()
        {
            char[] vowels = new char[5];
            vowels[0]=  'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';

            char[] vowels2 = new char[] { 'a', 'e', 'i', 'o', 'u' };
            for (int i= 0; i< vowels2.Length; i++)
            {
                Console.Write($"{vowels2[i]} ");
            }


        }

        public void TestPointArray()
        {
            // Point[] pointArray = new Point[3]
            var pointArray = new Point[3];
            for( int i = 0; i < pointArray.Length; i++ )
            {
                pointArray[i] = new Point()
                {
                    x = i,
                    y = i * 2
                };
                Console.WriteLine($"{pointArray[i].x}, {pointArray[i].y}");
            }
        }

        public void TestMultidimensionalArray()
        {
            // Rectangular arrays
            int[,] matrix = new int[3, 3];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (i * 3) + j;
                }
            }


        }
    }
}
