using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    public class InheritanceClass : Array
    {
        public void InheritingArrayofClass()
        {

            Console.WriteLine(x);
            //Console.WriteLine(this.Marks());
            //int y = 1;
            //y = y + x;
            this.Marks();
            //y = y + x;

        }
    }


    public class Employee
    {
        public string firstname = "r";

        protected string lastname;

        public string Fullname()
        {
            return(firstname + " " + lastname);
        }

    }

    class FulltimeEmployee : Employee
    {
         double monthlypay;
         int xx = 10;
        
        public void Employeemethod()
        {
            Console.WriteLine(lastname);
            Console.WriteLine(xx);
            Console.WriteLine(Fullname());
        }
    }

    class ParttimeEmployee : Employee
    {
            public double HourlyPay;
    }
    
}