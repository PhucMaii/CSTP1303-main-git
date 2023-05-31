using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ExceptionThrowing
    {
        private string message;
        private string messageTemplate;

        public void RunTest()
        {

        }
        public ExceptionThrowing(string messageTemplate, string message)
        {

            if (message == null)
            {
                throw new ArgumentNullException("message", "message can not be null");

            }
            this.message = message;
            this.messageTemplate = messageTemplate;
        }

        public void Log()
        {
            
        }
    }
}
