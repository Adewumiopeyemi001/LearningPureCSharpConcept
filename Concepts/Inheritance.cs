using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    internal class Inheritance
    {
        /*
            Inheritance
        Inheritance allows us to define a class in terms of another class
        One class(Base) share its members with another class(Derived), which allows reusability
        When a derived class is lacking the required member, it takes frm base class
        Base and derived classes have "is a" relationship

        Common features can be in base class while it can be inherity by derived class

        Derived class will only inherite those member or properties which are not present in itself



        */
    }
    class MyClass1
    {
        public void Method1()
        {
            Console.WriteLine("Method from myClass1....");
        }
    }
    class MyClass2 : MyClass1
    {
        public void Method2() 
        { 
            Console.WriteLine("Method from myclass2....");
        }
    }
}
