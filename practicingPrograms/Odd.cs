using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    public class Odd
    {


        public void OddNumbersOnly()
        {
            for(int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public string Reverse(string name)
        {
            string rString = String.Empty;
            char[] k = name.ToCharArray();
            for (int i = k.Length - 1; i >= 0; i--)
            {
                rString = rString + k[i];
                
            }
            Console.WriteLine(rString);
            return rString;
        }

        //public string name = "revthi";
        //public char[] name2 = name.ToCharArray();
    }
}
