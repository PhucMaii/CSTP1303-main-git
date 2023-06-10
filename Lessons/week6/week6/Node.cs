using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6
{
    public class BTNode<T>
    {
        public T Data { get; set; }

        public BTNode<T> Left { get; set; }

        public BTNode<T> Right { get; set; }


    }
}
