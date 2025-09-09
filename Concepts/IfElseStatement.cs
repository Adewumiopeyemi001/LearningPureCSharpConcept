using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class IfElseStatement
    {

        public static string Num(int num)
        {
            if (num % 2 == 0)
            {
                return "This is Even number";
            }
            else
            {
                return "This is Odd number";
            }

            // first check the condition either true or false to excute
            //you can compare multiple value here

        }

        public static string Percentage(float percent)
        {
            if(percent >= 80)
            {
                return "A";
            }
            else if (percent >= 60)
            {
                return "B";
            }
            else if(percent >= 40)
            {
                return "C";
            }
            else return "D";
        }

        //condition will only be checked if the previous condition is false
        //the program will terminate once the condition is true and the proceeding condition will not be checked

    }
}
