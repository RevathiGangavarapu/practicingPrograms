using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class Ifelse
    {
        public void IfelseProgram()
        {
            int a = 15; 

            if (a <= 10)
            {
                Console.WriteLine("Hi! how are you?");

            } else if (a <= 20) {

                Console.WriteLine("Welcome to India");

            } else if (a <= 30) {

                Console.WriteLine("Hello World!");
            }
            else
            {
                Console.WriteLine("Default Value");
            }

        }
    }
}
