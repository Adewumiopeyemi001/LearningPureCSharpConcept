using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    internal class LoopsIteration
    {
        /*
        Loops / Iteration statement
        Classied int : For Loop, While Loop, Do while loop and Foreach loop
        Loop will continue to iterate as long as the condition is true and will terminate when the condition is false
        Initialization, condition, updation





        */

        public static void ForLoop() 
        {
            int sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i); 
                sum = sum + i;
               
            }
            Console.Write(sum);
        }
    }
}
