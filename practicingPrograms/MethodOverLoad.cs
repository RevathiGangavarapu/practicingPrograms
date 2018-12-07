using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class MethodOverLoad
    {
        int a = 10;
        int b = 20;




        public void Add()
        {
            Console.WriteLine(a + b);
        }

        public void start()
        {
            Console.WriteLine("Enter firstname:");
          string name=   Console.ReadLine();
            Console.WriteLine("Enter lastname:");
            string lname = Console.ReadLine();

            Add(name,lname);
        }

        public void Add(string name, string lastname)
        {
            //return name + lastname;
            Console.WriteLine(name + " " +lastname);
        }

        public void Add(string name, string lastname, string somevalue)
        {
            //return name + lastname;
            Console.WriteLine("Value of string: {0}", name + lastname+ somevalue);
        }

        public void Add(int x, int y)
        {
            //passed string value.
            Console.WriteLine(x * y);
        }

        public void Add(int x, int y, int z)
        {
            Console.WriteLine(x + y+ z);
        }
    }
}
