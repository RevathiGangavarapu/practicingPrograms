using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class Forloop
    {
        public void ForLoopExample()
        {
            for (int i = 0; i<= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void ForLoopExample1()
        {
            for (int i = 2; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
            }
        }

        public void WhileLoopExample()
        {
            int a = 1;
            while (a <= 5)
            {
                Console.WriteLine(a);
                a++;
            }
        }

    }
}
