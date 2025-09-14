using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class ClassMember
    {
        /*
        Class Members
        everytin inside class are class members
        Classified as :
            Instance members / non-static
            Class members / static : common feature to all classes



        */

         int marks; //Instance
         static int maxmarks = 50; //Class

        void CalculatePercent()
        {
            int percent = marks * 100/maxmarks;
            Console.WriteLine(percent);
        }


    }
}
