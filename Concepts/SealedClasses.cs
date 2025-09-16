using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    internal class SealedClasses
    {
        /*
            Sealed Class
        Sealed class will behave as normal class but it can be made base class
        That means, sealed class cant be inherited
        Sealed class cant be abstract too

        */
    }
    //sealed
     class My1Class
    {
        public void SampleMethod()
        {
            Console.WriteLine("Sample Method in My1class");
        }
    }
    class My2Class : My1Class
    {

    }
}
