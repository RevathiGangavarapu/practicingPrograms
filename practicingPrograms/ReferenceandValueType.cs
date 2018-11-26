using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class ReferenceType
    {
        public void ReferenceExample(string name)
        {
            Console.WriteLine(name);
        }
    }

    class ValueType
    {
        public void ValueTypeExample()
        {
            int x = 100;
            int x1 = x;
            x = 4;
            Console.WriteLine(x1);
        }
    }

    public class TestReference
    {
        public string name;

        public string lastname;


    }
}
