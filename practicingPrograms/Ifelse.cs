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

        //Please enter Month:1
        //Month is Jan
        //Please enter Month:6
        //Month is June

        public void SwitchExamplePrgm()
        {
            bool flag = false;
            while (flag == false)
            {
                Console.WriteLine("Please Enter Month: ");
                int value1 = Convert.ToInt32(Console.ReadLine());

                switch (value1)
                {
                    case 1:
                        Console.WriteLine("month is January");
                        break;
                    case 2:
                        Console.WriteLine("month is Feb");
                        break;
                    case 3:
                        Console.WriteLine("month is march");
                        break;
                    case 4:
                        Console.WriteLine("month is april");
                        break;
                    case 5:
                        Console.WriteLine("month is may");
                        break;
                    case 6:
                        Console.WriteLine("month is june");
                        break;
                    default:
                        flag = true;
                        Console.WriteLine("entered default value");
                        break;

                       
                }
            }
        }
    }
}
