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

            //    Ifelse object1 = new Ifelse();
            //    object1.IfelseProgram();

            //    Forloop object2 = new Forloop();
            //    object2.ForLoopExample();
            //    object2.ForLoopExample1();
            //    object2.WhileLoopExample();

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

            //List1 object4 = new List1(55.5f);
            //object4.Write();
            //    object4.ListExample(96);
            //    /* now we can use both instance objects point out same object
            //     below one is not List of object. object4 is just a pointer to List object. */
            //    List object5 = object4;
            //    object5.ListExample(97);
            //    //object4.grades = 1.2;

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
            PassByReference object8 = new PassByReference();
            // object8.ReferenceTypesPassByValue();
            object8.getData();

            //array class
            //Array object9 = new Array();
            //object9.ArrayofMetodName();
            //object9.Marks();

            //InheritanceClass inher = new InheritanceClass();
            //inher.InheritingArrayofClass();
            //Odd obj1 = new Odd();
            //obj1.OddNumbersOnly();
            //obj1.Reverse("revathi");

            SubString str = new SubString();
            str.StringExg();

            ParttimeEmployee emp = new ParttimeEmployee();
            emp.firstname = "revati";
            emp.lastname = "ganga";
            emp.Name();
            
            emp.yearlysalary = 33.3f;

            Console.ReadLine();

        }
    }
}
