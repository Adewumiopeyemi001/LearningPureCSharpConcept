using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    internal class AbstractClass
    {
        /*
        Abstract Class
        Only abstract class can handle abstract method
        Abstract class cant be instantiated

        */
    }

    abstract class Persons
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract void Wor1k();
    }

    class Students : Persons
    {
        public override void Wor1k()
        {
            Console.WriteLine("It studies...");
        }
    }
    class Employees : Persons
    {
        public double Salary { get; set; }
        public string Designation { get; set; }
        public override void Wor1k()
        {
            Console.WriteLine("It earns.....");
        }
    }
    class Managers : Employees
    {
        public override void Wor1k()
        {
            //Console.WriteLine("It manage a team...");     
        }
    }
    class BranchManagers : Managers
    {
        public override void Wor1k()
        {
            Console.WriteLine("");
        }

    }
}
