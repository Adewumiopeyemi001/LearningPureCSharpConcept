using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    internal class GenericDelegate
    {
        /*
            Generic Delegate

        */
    }
    class Gen
    {
        public static void SampleMethod(string name)
        {
            Console.WriteLine("Welcome " + name);
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static bool Login(string uid)
        {
            if (uid == "opeyemi")
                return true;
            return false;
        }
    }
}
