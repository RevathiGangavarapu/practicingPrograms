using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    public class Array
    {
        public Array()
        {

        }
        public void ArrayofMetodName()
        {
            int[] array1 = new int[3];// array1 is variable name.
            ArrayofMetodName2(array1);
        }

        public void ArrayofMetodName2(int[] array1)
        {
            array1[0] = 56;
            array1[1] = 54;

            Console.WriteLine(array1[0]);
        }
        public int x = 10;
        public void Marks()
        {
            int[] markslist = new int[] { 93, 73, 34, 78, 98 };
            Console.WriteLine(markslist[0]);

            string[] studentnames;
                studentnames = new string[4] { "revati", "mouni", "krishaan", "srinivas" };
            if (studentnames[0] == "revati")
            {
                Console.WriteLine("Hi.revathi");
            }else if (studentnames[1] == "mouni")
            {
                Console.WriteLine("How Are You?");
            }
            else
            {
                Console.WriteLine("default value");
            }
            //Console.WriteLine(studentnames[0]);

            string fn = "revathi";
            string ln = "gangavarapu";
            Console.WriteLine(fn + " "+ ln);

            float[] percentageofstudents = new float[] { 3.4f, 5.6f, 7.8f, 4.8f }; //array length must be declared otherwise complier will ive error.
            Console.WriteLine("array of float value: {0}", percentageofstudents[0]);


            double[] doublevalue = new double[5] { 77.7, 67.7, 9.67, 7.6, 6.7};
            for (int i = 0; i <= doublevalue.Length-1; i++)
            {
                Console.WriteLine(doublevalue[i]);
            }

            foreach(double a in doublevalue)
            {
                Console.WriteLine("foreach example: {0}", a);
            }


            
        }
    }
}
