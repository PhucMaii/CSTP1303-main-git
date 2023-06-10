using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6
{
    public class TestDelegate
    {
        public delegate void Reporter(int percent);

        public void Test1()
        {
            var r = new DelegateExample2();
            Reporter reporter = r.ProgressReporter;
            
            for(int i =0; i < 100; i++) 
            {
                reporter(i);
            }
        }
    }
}
