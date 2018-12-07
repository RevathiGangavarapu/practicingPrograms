using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicingPrograms
{
    class SubString
    {
        public void StringExg()
        {
            string testStr = "abcdddd-revathi";
             string name = "RevathiGangavarapu";
            Console.WriteLine(name.Substring(5));//retrieve the substring from index 5
            Console.WriteLine(name.Substring(0,5));//retrieve the substring from index 0 to 5.

            string name2 = "hello..how are you?";
            Console.WriteLine("substringValue: " + name2.Substring(0, 5));
            Console.WriteLine("substringValue2: {0}", name2.Substring(0, 5));

           int ind= name.IndexOf("G");
           string[] testStrSplit=  testStr.Split('-');
        }               
    }
}
