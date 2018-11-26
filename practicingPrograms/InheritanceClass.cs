using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class InheritanceClass: Array
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

    public class FulltimeEmployee
    {
        public string firstname;
        public string lastname;
        public float yearlysalary;

        public string EmployeeFullName()
        {
           return (firstname + " " + lastname);
        }
    }

    public class ParttimeEmployee: FulltimeEmployee
    {
        public float hourlysalary;
        public void Name()
        {
            Console.WriteLine(this.EmployeeFullName());
        }
    }
}
