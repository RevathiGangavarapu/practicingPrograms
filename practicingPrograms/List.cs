using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class List1
    {
        public List<float> grades = new List<float>();

        public List1()
        {
        }

        public List1(float Grade)
        {
                  
            grades.Add(Grade);
           
        }
        public void Write()
        {
            foreach (var f in grades)
            {
                Console.WriteLine(f);
            }
            Console.ReadLine();
        }


    }
}
