using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class ImplementingClass
    {
        /*
        Implementing classes


        */
        int marks;
        public void CalculatePercent() 
        {
           
            int percent = marks * 100 / 50;
            Console.WriteLine(percent);

        }
        /*
        Test t1 = new Test();
        t1.marks = 43;
        t1.CalculatePercent();

        */
    }
}
