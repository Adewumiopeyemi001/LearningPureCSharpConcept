using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    internal class MethodOverriding
    {
        /*
            Method Overriding
        Performs dynamic polymorphism : every object will be bound with its particular component, method or properties
        Allows you to invoke method that belongs to different class in same 
        hierarchy using the base class reference
        Virtual and Override keywords are used to implement method overriding

        */
    }
    class Person1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void Wor1k()
        {
            Console.WriteLine("It works....");
        }
    }

    class Student : Person1 
    {
        public override void Wor1k()
        {
            Console.WriteLine("It studies...");      
        }
    }
    class Employee2 : Person1
    {
        public double Salary { get; set; }
        public string Designation { get; set; }
        public override void Wor1k()
        {
            Console.WriteLine("It earns.....");
        }
    }
    class Manager : Employee2
    {
        public override void Wor1k()
        {
            //Console.WriteLine("It manage a team...");     
        }
    }
    class  BranchManager : Manager
    {
        public override void Wor1k() 
        {
            Console.WriteLine("");
        }
        
    }
}
