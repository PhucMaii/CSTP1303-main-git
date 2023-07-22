using System;

namespace StreamIntroduction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.FileStreamExample();
        }
        public void FileStreamExample()
        {
            // create a file in the current directory 
            using (Stream s = new FileStream("MyTest.txt", FileMode.OpenOrCreate))
            {
                Console.WriteLine(s.CanRead);
                Console.WriteLine(s.CanWrite);
                Console.WriteLine(s.CanSeek);

                s.WriteByte(101);
                s.WriteByte(102);

                byte[] bytes = { 65, 66, 67, 68, 69 };

                s.Write(bytes, 0, bytes.Length);
                Console.WriteLine(s.Length);
                Console.WriteLine(s.Position);

                s.Position = 0;

                Console.WriteLine(s.ReadByte()); // 101
                Console.WriteLine(s.ReadByte()); // 102
                Console.WriteLine(s.Read(bytes, 0, bytes.Length));
                Console.WriteLine(s.ReadByte()); // 65

            }
        }
    }
}