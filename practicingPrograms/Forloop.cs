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
                    if (i == 3 && j == 5) { }

                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);

                   
                }
            }

            List<int> intlist = new List<int> { 1, 2, 3, 4, 5 };

            for (int i = 0; i < intlist.Count; i++)
            {
                Console.WriteLine(intlist[i]);
            }

            foreach (var item in intlist)
            {

                Console.WriteLine(item);
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
