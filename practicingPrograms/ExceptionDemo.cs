using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class ExceptionDemo
    {

        public int divide(int a, int b)
        {
            int q = 0;
            try
            {

                //conn ope
                int c = 10;
                int g = 30;
                 q = a / b;

                //conn close

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                //conn close
            }
            

            return q;
        }

    }
}
