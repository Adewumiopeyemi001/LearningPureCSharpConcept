using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class Operators
    {

        /*
        Is a symbol that tells the complier to perform specific operation
        Operationally, can be classified in :
            Arithmetic Operator
            Relational/Comparison Operator
            Logical Operator

        int a = 10;
        a = a + 5; or
        a += 5

        int a = 10;
        int b = a++

        int a = 10;
        int b = ++a


        

        public int a = 10;
        public int b = 20;

        public int Sum() { return a + b; }
        public int Min() { return a - b; }

        */

        public static int Sum(int a, int b) => a + b;
      

        public static int Min(int a, int b) => a - b;
    }
}
