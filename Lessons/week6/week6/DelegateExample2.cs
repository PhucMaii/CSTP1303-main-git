using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6
{
    public class DelegateExample2
    {
        private string prefix = "% complete";

        public void ProgressReporter(int percentComplete)
        {
            Console.WriteLine($"{this.prefix}{percentComplete}");
        }
    }
}
