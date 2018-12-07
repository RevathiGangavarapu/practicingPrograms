using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class PassByValueDemo
    {
        public int add(ref int a,int b)
        {
            a = 5;
            return a + b;
        }
    }
}
