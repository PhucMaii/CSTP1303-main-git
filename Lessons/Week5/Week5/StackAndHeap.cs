using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class StackAndHeap
    {
        public int Factorial(int x)
        {
            if(x == 0)
            {
                return 1;
            }
            return x * Factorial(x-1);
        }
    }
}
