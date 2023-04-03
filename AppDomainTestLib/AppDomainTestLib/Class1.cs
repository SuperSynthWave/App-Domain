using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainTestLib
{
    public class MyClass : MarshalByRefObject
    {
        public string className { set; get; }
        public static string idName = "NO_ID";

        public MyClass()
        {

        }

        public void setClassName(string classnm)
        {
            this.className = classnm;
        }

        public void setIDName(string idname)
        {
            idName = idname;
        }

        public string getIdName()
        {
            return idName;
        }

        public void setStaticVars(string value1)
        {
            MyStaticClass.val1 = value1;
            MyStaticClass.inited = true;
        }

        public void getStaticVars()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(MyStaticClass.inited.ToString() + "\n");
            Console.WriteLine(MyStaticClass.val1);
        }

    }

    public static class MyStaticClass{
        public static string val1 = "NO_VAL";
        public static bool inited = false;

}

}
