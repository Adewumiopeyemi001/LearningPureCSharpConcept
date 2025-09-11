using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class WhileLoop
    {
        /*

        While Loop : Repeatedly executes statements as long as a given condition is true.
        Condition => Conditional code
        WhileLoop is used when we dont know the number of execution


        */

        public static void WhileLoops()
        {
            int count = 0;
            int num = 1;

            while (count < 100)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    Console.Write(num + "\t");
                    count++;
                }
                num++;
            }
            Console.WriteLine();


        }

        public static void WhileLoop2()
        {
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int digits = 0;
            while (temp != 0) 
            { 
                digits++;
                temp = temp / 10;
            }
            Console.WriteLine("{0} is {1} digit number.", num, digits);
        }
    }
}
