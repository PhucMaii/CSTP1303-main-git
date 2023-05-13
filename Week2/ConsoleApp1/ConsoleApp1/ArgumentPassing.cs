using System;

namespace ConsoleApp1
{
    public class ArgumentPassing
    {   
        public void RunTest()
        {
            var n = 0;
            this.Increment(n);
            Console.WriteLine(n);

            this.Increment(ref n);
            Console.WriteLine(n);
        }

        public void Increment(int i )
        {

            if (i > 10)
            {
                Console.WriteLine("i cannot be incremented");
            } else
            {
                i = i + 1;

            }
            Console.WriteLine(i);

        }

        public void Increment(ref int i)
        {

            if (i > 10)
            {
                Console.WriteLine("i cannot be incremented");
            }
            else
            {
                i = i + 1;

            }
            Console.WriteLine(i);

        }
    }
}
