using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class JumpStatement
    {
        /*
        You can jump from one location to other in the code
        Used to jump in a particualr position in a program
        Classified as : Break, Continue, Goto and Return

        Break: Used to terminate the loops and switch statement

        Continue: Continue will skip a particular loops circle
        It forces the next iteration of the loops to take place, skipping any code in between

        GoTo: Provides an unconditiona jump from the "Goto to a labeled
        statement in the same function


        */

        public static void Breaks()
        {
            for (int i = 1; i < 10; i++)
            {
                if(i == 5)
                    //break out or stopped at 5
                    break;
                Console.WriteLine("i = " + i);
            }
        }

        public static void Continue() 
        {
            for (int i = 1; i < 10; i++)
            {
                if (i == 5 && i == 7)
                    // will skipped 5 and 7
                    continue;
                Console.WriteLine("For continue i = " + i);
            }
        }

        public static void GoTo() 
        { 
            int i = 1;
            //abc is a label here
        abc:
            Console.WriteLine(i);
            i++;
            if (i <= 10)
                goto abc;
        }

        public static void Return()
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if(num2 == 0)
            {
                Console.WriteLine("Cannot divide a number by 0");
            }

            int result = num1 / num2;
            Console.WriteLine("Result is: ", result);

        }
    }
}
