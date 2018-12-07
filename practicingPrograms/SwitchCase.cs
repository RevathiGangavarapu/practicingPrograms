using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class SwitchCase
    {
        public void SwitchCaseExample()
        {
            Employee e = new PEmployye();
           
            int a = 10; int b = 20; string Value = "Add";
            switch (Value)
            {
                case "Add":
                    Console.WriteLine(a + b);
                    break;
                case "Sub":
                    Console.WriteLine(a - b);
                    break;
                case "Mul":
                    Console.WriteLine(a * b);
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }

        public void Calculator(int x, int y, string Value)
        {
            if (Value == "Add")
            {
                Console.WriteLine(x + y);

            } else if (Value == "Sub") {

                Console.WriteLine(x - y);

            } else if (Value == "Mul"){

                Console.WriteLine(x * y);
            }
            else
            {
                Console.WriteLine("default value");
            }
        }
    }
}
