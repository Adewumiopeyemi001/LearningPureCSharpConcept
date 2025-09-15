using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    internal class DataHiding
    {
        /*
         * Data Hiding or Shawoding

        */
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Work()
        {
            Console.WriteLine("It works...");
        }
    }
     class Employee1 : Person
    {
        public double Salary { get; set; }
        public string Designation { get; set; }
        public new static void Work()
        {
            Console.WriteLine("It earns...");
        }
    }
}
