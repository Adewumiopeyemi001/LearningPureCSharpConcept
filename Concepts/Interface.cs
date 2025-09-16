using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    internal class Interface
    {
        /*
        Interface
        Interface is a reference type data type

        Gives complete abstraction
        Provides multiple inheritance

        Whenever you want to inherit class and interface together, class must come first
        you can inherit as many interface as possible
        All the method in the interface must be initialized

        */
    }

    interface IInterface1
    {
        void Method1();
        void Method2();
    }
    interface IInterface2
    {
        void Method2();
    }
     class MyClass
    {
        public void M1()
        {
            Console.WriteLine("M1 from MyClass2");
        }
    }
    class MyClass22 : MyClass, IInterface1, IInterface2
    {
        public void Method1() 
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
}
