using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    internal class Delegate
    {
        /*
        Delegates is a part of reference type.
        Is a reference type variable that holds the reference to a method
        Used for implementing events and the call-back methods
        Implicitly derived from the System.Delegate class
        Delegate holding the reference of multiple methods is called multicast delegate



        */
    }

    //delegate int MyDel(int x, int y);
    public class Deligates
    {
        public delegate int MyDel(int x, int y);
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y) 
        { 
            return x * y;
        }
        
       
     }
}
