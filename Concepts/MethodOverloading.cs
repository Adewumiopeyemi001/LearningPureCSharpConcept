using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class MethodOverloading
    {
        /*
        Static Polymophisis
        creating diff method with same name having different parameters, 

        you can only override visual method or abstract method
        sealed method cant be inherited

        */

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public static void Work()
            {
                Console.WriteLine("It works.....");
            }

        }
        class Employee : Person 
        {
            public double Salary { get; set; }
            public string Designation { get; set; }

            public new static void Work()
            {
                Console.WriteLine("It earns........");
            }
        }
    }
}
