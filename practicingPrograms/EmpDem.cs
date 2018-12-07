using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class EmpDem
    {
        public int? a;
        public int b;

        public int getSum()
        {
            //if (a.HasValue)
            //    return a.Value + b;
            //else return b;

            return a ?? 10 + b;

        }

        int x;
        string y;
        float z;
        double x1;
        bool y2;
         
        public void DefaultValueofDataTypes()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(x1);
            Console.WriteLine(y2);
        }
    }

    class ConstructorDemo2
    {
        private readonly EmpDem _em;
        public ConstructorDemo2(EmpDem em)
        {
            _em = em;

            Console.Write(_em.a);
            Console.Write(_em.b);
           
        }

        public int doAdd()
        {
            return _em.getSum();
        }

    }


}
