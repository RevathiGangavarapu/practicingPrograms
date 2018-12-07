using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class Program
    {
       static void Main(string[] args)
       {

            //PassByValueDemo p = new PassByValueDemo();
            //int a = 20;
            //int b = 30;
            //Console.WriteLine(  p.add(ref a, b));
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            // ExceptionDemo ed = new ExceptionDemo();
            //Console.Write( ed.divide(3 , 0));


            List<Customer> cList = new List<Customer>();
            PrimeCust p = new PrimeCust();
            p.id = 1;
            p.Name = "revati";
            Console.WriteLine(p.getDiscount());
            NormalCust n = new NormalCust();
            n.id = 2;
            n.Name = "srinivas";
            Console.WriteLine(n.getDiscount());
            PrimePlatinumCust pp = new PrimePlatinumCust();
            pp.id = 3;
            pp.Name = "krishaan";
            Console.WriteLine(pp.getDiscount());
            Console.ReadLine();
            cList.Add(p);
            cList.Add(n);
            cList.Add(pp);


            //foreach (var c in cList)
            //{
            //    Console.WriteLine(c.getDiscount());

            //}


            //EmpDem ed = new EmpDem();
            //ed.b = 20;

            //ed.getSum();
            ////ConstructorDemo cd = new ConstructorDemo(100,200);
            ////cd.Add();
            ////ConstructorDemo cd2 = new ConstructorDemo(100, 200,300);

            ////ConstructorDemo cd1 = new ConstructorDemo();

            //ConstructorDemo cd5 = new ConstructorDemo(30,100,200);

            ////cd1.a = 300;
            ////cd1.b = 400;

            ////cd1.Add();

            ////Set is called for a and b
            //ConstructorDemo cd3 = new ConstructorDemo() { a=500,b=600};

            ////Get is called for a
            //Console.Write(cd3.a);


            //////////////Const Demo 2
            //EmpDem em = new EmpDem() { a = 10, b = 20 };
            //EmpDem em = new EmpDem();
            //em.a = 10;
            //em.b = 20;
            //ConstructorDemo2 cd21 = new ConstructorDemo2(em);
            //ConstructorDemo cd3 = new ConstructorDemo(35);
            //ConstructorDemo cd = new ConstructorDemo();
            //cd.a = 10;
            //cd.b = 20;
            //cd.Demo();
            //ConstructorDemo cd11 = new ConstructorDemo(25, 34);
            //cd11.Demo();
            //ConstructorDemo cd1 = new ConstructorDemo(50, 60);
            //cd1.Demo();
            //ConstructorDemo cd2 = new ConstructorDemo() { a = 500, b = 600 };
            //cd2.Demo();
            ////cd2.value1 = 3;
            //cd2.value2 = 56;
            //cd2.resultofnullablevalue();
            //Console.WriteLine(cd2.a);

            //EmpDem d = new EmpDem();
            //d.DefaultValueofDataTypes();


            /*---------------------------------------------------*/
            //paramDemo pd = new paramDemo();
            //string a = "Revathi";
            //string b = "G";
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Console.WriteLine(pd.add(ref a,b));

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Employee obje6 = new Employee();
            //FulltimeEmployee inheri = new FulltimeEmployee();
            //inheri.firstname = "revathi";
            //inheri.lastname = "gangavarapu";
            //inheri.monthlypay = 1234.45;



            //MethodOverLoad obj8 = new MethodOverLoad();
            //obj8.Add();
            //obj8.Add(2, 7, 6);
            //obj8.Add("4", "5", "hello");
            //obj8.Add("revathi", "ganavarapu");
            //obj8.Add( Convert.ToInt32( "5"), Convert.ToInt32("6"));

            //Example obj10 = new Example();
            //obj10.Methodname1();
            //Console.WriteLine();
            //Console.ReadLine();
            //// IfElse example.
            //Ifelse object1 = new Ifelse();
            //object1.SwitchExamplePrgm();
            //object1.IfelseProgram();

            // Forloop object2 = new Forloop();
            //object2.ForLoopExample();
            //object2.ForLoopExample1();
            //object2.WhileLoopExample();
            //Console.Read();

            //    SwitchCase object3 = new SwitchCase();
            //    object3.SwitchCaseExample();

            //    // accessing console Values
            //    Console.WriteLine("Enter Value1:");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    int y;
            //    Console.WriteLine("Enter Value2:");
            //    y = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Choose one method: 1.Add, 2.Sub, 3.Mul");
            //    string Value =Console.ReadLine();
            //    object3.Calculator(x, y, Value);
            List1 object4 = new List1(56.5f);
            object4.grades.Add(57.5f);
            object4.grades.Add(23);
            object4.grades.Add(45);
            object4.Write();
            //object4.ListExample(96);
            /* now we can use both instance objects point out same object
             below one is not List of object. object4 is just a pointer to List object. */
            List1 object5 = object4;
            
            /////object5.ListExample(97);
            //object4.grades = 1.2;

            //reference type 

            //ReferenceType value = new ReferenceType();
            //value.ReferenceExample("revathi");
            //ReferenceType value1 = value;  // value1 pointing to same object of pointer.
            //value1.ReferenceExample("krishaan");

            ////valuetype

            //ValueType object6 = new ValueType();
            //object6.ValueTypeExample();
            ////object6.ValueTypeExample(25);

            ////passbyvalue
            //PassByValue object7 = new PassByValue();
            //object7.ValueTypesPassByValue();

            ////pass by reference
            //PassByReference object8 = new PassByReference();
            //// object8.ReferenceTypesPassByValue();
            //object8.getData();

            //array class
            //Array object9 = new Array();
            //object9.ArrayofMetodName();
            //object9.Marks();

            //InheritanceClass inher = new InheritanceClass();
            //inher.InheritingArrayofClass();
            //Odd obj1 = new Odd();
            //obj1.OddNumbersOnly();
            //obj1.Reverse("revathi");

            //SubString str = new SubString();
            //str.StringExg();

            //ParttimeEmployee emp = new ParttimeEmployee();
            //emp.firstname = "revati";
            //emp.lastname = "ganga";
            //emp.Name();

            //emp.yearlysalary = 33.3f;

            //Console.ReadLine();

        }
    }
}
