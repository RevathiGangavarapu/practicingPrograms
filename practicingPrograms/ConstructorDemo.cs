using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class ConstructorDemo
    {

        //private readonly int myreadonly;
        //public ConstructorDemo()
        //{

        //}

        //public ConstructorDemo(int myreadonlyi, int inputa, int inputb)
        //{
        //    myreadonly = myreadonlyi;
        //    a = inputa;
        //    b = inputb;
        //}

        ////public ConstructorDemo(int inputa,int inputb,int inputc=0)
        ////{
        ////    a = inputa;
        ////    b = inputb;
        ////}
        //public int a { get; set; }
        //public int b { get; set; }
        //public void Add()
        //{
        //    //Instead of doing the add here,we can call the add function on MethodOverLoad class
        //    MethodOverLoad m = new MethodOverLoad();
        //    m.Add(a, b);
        //    Console.Write(myreadonly);

        //    Console.WriteLine(a + b);
        //}

        private readonly int myreadonly=10;
        public ConstructorDemo(int myreadonlyi)
        {
            myreadonly = myreadonlyi;
            Console.WriteLine("Readonly Value: {0}..Half of it is : {2}", myreadonly,myreadonly/2);

            Console.WriteLine("Readonly Value: "+ myreadonly+ ".Half of it is :"+ myreadonly/2);
        }

        public void add1tord()
        {
            Console.WriteLine(myreadonly+1);
        }

        public ConstructorDemo(int value1, int value2)
        {
            a = value1;
            b = value2;
        }
        public ConstructorDemo()
        {

        }
        public int a { get; set; }
        public int b { get; set; }

        public void Demo()
        {
            Console.WriteLine(a + b);
            Console.WriteLine(a - b+ myreadonly);
            Console.WriteLine(myreadonly);
        }

        public int? value1;//nullable value
        public int value2;

        public void resultofnullablevalue()
        {
            Console.WriteLine(value1 ?? 1200 + value2);// if value1 is null, here we are assigning value1 is 1200.
        }
    }

}
