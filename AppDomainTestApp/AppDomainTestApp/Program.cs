using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain appDomain = AppDomain.CreateDomain("MyAppDomain");

            AppDomainTestLib.MyClass myClassObj = (AppDomainTestLib.MyClass)appDomain.CreateInstanceFromAndUnwrap(@"C:\Users\Gagan\Desktop\AppDomainTestLib\AppDomainTestLib\bin\Debug\AppDomainTestLib.dll", typeof(AppDomainTestLib.MyClass).FullName);
            Console.WriteLine("App Domain created");

            myClassObj.setClassName("gagan's_class");
            myClassObj.setIDName("test1");
            Console.WriteLine(myClassObj.className);

            AppDomain newAppDomain = AppDomain.CreateDomain("NewAppDomain");
            AppDomainTestLib.MyClass newClassObj = (AppDomainTestLib.MyClass)newAppDomain.CreateInstanceFromAndUnwrap(@"C:\Users\Gagan\Desktop\AppDomainTestLib\AppDomainTestLib\bin\Debug\AppDomainTestLib.dll", typeof(AppDomainTestLib.MyClass).FullName);
            newClassObj.setClassName("gagan's_new_class");
            newClassObj.setIDName("test235");
            Console.WriteLine(newClassObj.className);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine(myClassObj.getIdName() + "\n");
            Console.WriteLine(newClassObj.getIdName() + "\n");
            myClassObj.getStaticVars();
            myClassObj.setStaticVars("obj1");
            myClassObj.getStaticVars();
            newClassObj.getStaticVars();
            newClassObj.setStaticVars("obj2");
            newClassObj.getStaticVars();
            Console.ReadKey();
        }
    }
}
