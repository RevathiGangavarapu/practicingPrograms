using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class PassByValue
    {        
       
        public void ValueTypesPassByValue()
        {
            int x = 23;
            IncrementNumber(x);
        }

        public void IncrementNumber(int y)
        {
            y = y + 1;
            Console.WriteLine(y);
        }

        public Emp ReturnObj()
        {
            DBClass a = new DBClass();
            Emp b =  a.getData();
            return b;
        }


    }

}
