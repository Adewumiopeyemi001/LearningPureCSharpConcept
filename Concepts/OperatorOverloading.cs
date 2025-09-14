using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class OperatorOverloading
    {
     

    }
    class Length
    {
        public int feet, inch;
        public Length ( )
        {
            this.feet = 0;
            this.inch = 0;
        }
        public Length(int feet, int inch)
        {
            this.feet=feet;
            this.inch = inch;
        }
        public static Length operator +(Length l1, Length l2)
        {
            Length l3 = new()
            {
                feet = l1.feet + l2.feet,
                inch = l1.inch + l2.inch
            };
            if (l3.inch >= 12)
            {
                l3.feet++;
                l3.inch -= 12;
            }
            return l3;
        }
    
        public static bool operator >(Length l1, Length l2)
        {
            if (l1.feet > l2.feet)
                return true;
            else if (l1.feet == l2.feet)
                return l1.inch > l2.inch;
            else
                return false;
        }

        public static bool operator <(Length l1, Length l2)
        {
            if (l1.feet < l2.feet)
                return true;
            else if (l1.feet == l2.feet)
                return l1.inch < l2.inch;
            else
                return false;
        }
        public string GetLength()
        {
            return string.Format("Length : {0}' {1}\"", feet, inch);
        }
    }


}
