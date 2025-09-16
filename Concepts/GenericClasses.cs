using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    internal class GenericClasses
    {
        /*
       Generic Classes
        we can pass the data type at the runtime unlike other 
        classes that we have to specify the data type while creating them

        it gives advantage of customize the data type

        */
    }
    class My3Class<T1, T2>
    {
        public T1 MyProperty { get; set; }
        public void Method(T1 p1, T2 p2)
        {
            Console.WriteLine($"p1 = {p1}, p2 = {p2}");
        }
    }
}
