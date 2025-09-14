using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class Methods
    {

        /*
Group of statements that together perform a task
Task is performed when we invoke the method
Every program has ta least one method call main
Input value can be given from parameters/arguments
Void means the method will not return any value
Using static: You dont have to initialize the instance object of the class

        Ways of calling method:
        Call by Value
        Call by Reference
        Call by Output
        Call by Params


*/

        public static int Add(int x, int y) //Formal argument
        {
            int sum = x + y;
            //Console.WriteLine(sum);
            return sum;
        }
        public static char GetGrade()
        {
            float percent = GetPercentage();
            if (percent >= 80)
                return 'A';
            else if (percent >= 60)
                return 'B';
            else if (percent >= 40)
                return 'C';
            else
                return 'D';
        }
        public static float GetPercentage() 
        {
            float totalmarks = GetTotal();
            float percentage = totalmarks * 100 / 300;
            return percentage;
        }
        public static float GetTotal()
        {
            Console.Write("Enter Mark 1: ");
            float marks1 = float.Parse(Console.ReadLine());

            Console.Write("Enter Mark 2: ");
            float marks2 = float.Parse(Console.ReadLine());

            Console.Write("Enter Mark 3: ");
            float marks3 = float.Parse(Console.ReadLine());

            float total = marks1 + marks2 + marks3;
            return total;
        }

        public static int Addition(int num1, int num2, params int[] list)
        {
            int sum = num1 + num2;
            foreach (int item in list)
            {
                sum += item;
            }
            return sum;
        }
    }
}
