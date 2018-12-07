using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{

    class PDemo
    {
       public static  Lit<Product> pList = new List<Product>() { new Product() {id=1,name="ipad",price=259 },
           new Product() {id=2,name="ipone",price=700 }
       };
       
    }


    abstract class Customer 
    {
        public int id { get; set; }
        public string Name { get; set; }

        //public abstract float getDiscount1();

        public  float getDiscount2()
        {
            return 3;
        }


        //public virtual float getDiscount()
        //{
        //    return 2.5f;
        //}
    }

    class NormalCust: Customer, ICustomer
    {
        public string CustType { get { return "N"; } }

        public float getDiscount()
        {
            return 1f;
        }

        public float getPrice(int productID)
        {
            float prodPrice = PDemo.pList.Where(x=>x.id == productID).SingleOrDefault().price;
            float discPrice = prodPrice * getDiscount() / 100;
            return prodPrice-discPrice;
        }


        //public override float getDiscount1()
        //{
        //    return 1;
        //}
    }

    class PrimeCust: Customer, ICustomer
    {
        
        public string CustType { get { return "P"; } }

        public  float getDiscount()
        {
            return 3.5f;
        }

    }

    class PrimePlatinumCust : Customer, ICustomer
    {
        public string CustType { get { return "PP"; } }
        public float getDiscount()
        {
            return 5.5f;
        }
    }


    interface ICustomer
    {
        string CustType { get;  }
        float getDiscount();
        float getPrice();
    }

    

}
