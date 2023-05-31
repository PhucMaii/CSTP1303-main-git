using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TryCatch
    {
        public void RunTest()
        {
            try
            {
                var et = new ExceptionThrowing("234", null);
                Console.WriteLine("after returning from test");

            } catch(ArgumentNullException ans)
            {
                Console.WriteLine("PLease Enter a Valid Value");
            } 
            catch(Exception ex)
            {
                Console.WriteLine
                    (ex);
            }
        }

        public void RunTest2()
        {
            var et = new ExceptionThrowing("234", null);
            Console.WriteLine("after returning from test");
        }
    }
}
