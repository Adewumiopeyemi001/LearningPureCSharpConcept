using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class SwitchStatement
    {
        //Switch Statement
        //Allows a variable to be tested for equality agaisnt a list of values
        //Each value is called a case
        //Every "case" and default must be terminated by "break" statement
        //you can compare multiple values
        //the sequence doesnt matter
        //not compulsory to include default block

        public static string Alphabeth(char ch)
        {
            string s = ch.ToString().ToLower();

            //return s switch
            //{
            //    "a" => ("a is vowel"),
            //    "e" => ("e is vowel"),
            //    "i" => ("i is vowel"),
            //    "o" => ("o is vowel"),
            //    "u" => ("u is vowel"),
            //    _ => ("is a consonant"),
            //};

            switch(s)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    return $"{s} is a vowel";
                default:
                    return $"{s} is a consonant";
            }
        }

    }
}
