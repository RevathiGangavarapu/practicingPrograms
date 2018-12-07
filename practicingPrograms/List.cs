using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class List1
    {
        public List1(float g)
        {     
            grades.Add(g);
        }

        public List<float> grades = new List<float>() { 1,2,3,4,5};
        //{ 1, 2, 3 }
        public void Write()
        {
            float sum = 0;
            foreach (var f in grades)
            {
                sum = sum + f;
               Console.WriteLine(f);
               
            }
            Console.Write("Total Sum of List: " + sum); 
            Console.WriteLine("count of list" + grades.Count);
            Console.ReadLine();
            
        }

    }
}
