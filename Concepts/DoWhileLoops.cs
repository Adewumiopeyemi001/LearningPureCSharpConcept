using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    internal class DoWhileLoops
    {
        /*
        Checks its condition at the end of the loop
        do... while loop is guaranted to execute at least one time even if the condition is false
        the loop will execute once even before the condition is been checked
        while condition need to be terminated by semi-colon
        we use do while loop especially while collecting user info repeatedly


        */

        public static void While()
        {
            string actualPin = "1234";
            int count = 0;
            string pin;

            do
            {
                pin = Console.ReadLine();
                count++;
            }
            while (pin != actualPin && count < 3);

            if (pin == actualPin)
                Console.WriteLine("Welcome User");
            else
                Console.WriteLine("Account Locked");
           
        }

    }
}
