using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class PracticeLoops
    {
        public static void LoopNum()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void LoopNum2()
        {
            int i = 2;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }

        public static void LoopNum3() 
        {
        }

    }
}
