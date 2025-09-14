using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class Strings
    {
        /*
        convert character array to string : string greeting = new string(letter)
        convert 

        */

        public static string StringPractice() 
        {
            string fname, lname;
            fname = "Opeyemi";
            lname = "Mathew";

            string fullname = fname + lname;
            //Console.WriteLine("Full name: {0}", fullname);
            return fullname;
        }
        // By using string constructor
        public static string StringPractice2() 
        {
            //Converting from array to string
            char[] letters = ['H', 'E', 'L', 'L', 'O'];
            string greetings = new(letters);

            //Converting from string to character array
            //char[] ch = greetings.ToCharArray(); 

            return greetings;
        }
        
        //Methods returning string
        public static string StringPractice3() 
        {
            string[] sarray = ["Heelo", "From", "Tutorials", "Class"];
            string message = String.Join(" ", sarray );
            return message;
        }

        public static string StringPractice4()
        {
            DateTime waiting = new(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            return chat;
        }

    }
}
