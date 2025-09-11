using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class  ForLoops
    {
        /*
        Used when number of iteration or conditions are knowns
        init; condtion; increment 
        we can also have decrement

        Nesting of loops

        */

      public static void ForLoop()
        {
            //int num = int.Parse(Console.ReadLine());


            
            for (int num = 0; num < 100; num++)
            {
                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                        isPrime = false;
                    break;

                }
                if (isPrime)
                    Console.WriteLine(num);

            }


        }
        


    }
}
