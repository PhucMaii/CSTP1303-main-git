using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{
    public class Threading
    {
        public void BasicThreadExecution()
        {
            Thread thread1 = new Thread(ThreadToWrite);
            thread1.Start();

            // main thread executing this
            for(int i = 0; i < 1000; i++)
            {
                Console.Write("-");
            }


        }

        // addition thread executing this
        public void ThreadToWrite()
        {
            for(int i = 0; i < 1000; i++) 
            {
                Console.Write("*");
                /*Thread.Sleep(50);*/
                Thread.Yield();
            }
            Console.WriteLine("=========Finished Loop ==========");

        }       
    }
}
