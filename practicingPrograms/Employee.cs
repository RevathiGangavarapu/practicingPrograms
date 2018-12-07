using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{

    /*Enter first Name:
     * Enter Las Name:
     * Enter employee type:P/F
     * if Employe Type =P , enter hourly pay:
     * if employe type=F,enter monty pa
     * ------------------
     *Print this---- Hi FirstName - Last Name .Your annual salry is :......
     * if employe type ='P' ,hourly pay*8*20*12
     * if emploe tye =F,monthly pay *12
     * */

    public class HelloEmployee
    {
        public int a = 10;
        public string fName;
        public string lName;
        internal string fullName { private set { }  get { return fName + "-" + lName; } }

        
       
    }

     class PEmployye :Employee
    {
        public int HPay { get; set; }

        public int add(int a,int b)
        {
            return a + b;
        }

        public string add(string a,string b)
        {
           return a + b;

        }

        public int add(string a, string b,string c)
        {
            return Convert.ToInt32( a + b + c);
            //return Convert.ToInt32(a) + Convert.ToInt32(b) + Convert.ToInt32(c);

        }


    }

    public class FEmployye : Employee
    {
        public int MPay { get; set; }


    }


    public class paramDemo
    {
        public string add(ref string a, string b)
        {
            a = a + "ABC";
            return a + b;
            
        }

    }


}
