using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class PassByReference
    {
        public void ReferenceTypesPassByValue()
        {
            //ReferenceType value = new ReferenceType();
            ////value.ReferenceExample("revathi");
            //ReferenceType value1 = value;  // value1 pointing to same object of pointer.
            ////value1.ReferenceExample("krishaan");

            //Reference(value1);
            //TestReference testReference = new TestReference();
            //testReference.lastname = "nalabothula";
            //testReference.name = "Ravathi";
            string name = "test";
           
            this.Reference1(ref name);
            this.PassByValueEg(name);

        }

        //private void Reference(ReferenceType value3)
        //{
        //    value3.ReferenceExample("srinivas");
        //}

        public void Reference1(ref string name123)
        {
            name123 = "test 2";
        }

        public void PassByValueEg(string name)
        {
            name = "test 3";


        }

        public void getData()
        {
            PassByValue obj = new PassByValue();
            Emp k =  obj.ReturnObj();
        }


    }
}

