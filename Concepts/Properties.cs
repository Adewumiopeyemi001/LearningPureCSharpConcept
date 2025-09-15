using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class Properties
    {
        /*
        Properties
        Properties is used to validate the incoming data in data members
        Are the named member in a class
        Is used to provide restricted access to data members
        Accessor like 'Set and 'Get' are used for validation





        */
    }
        class Accounts
        {
            float init_amount;
            static float interest;
            public float InitialAmount
            {
                set
                {
                    if (value < 10000)
                    {
                        Console.WriteLine("Initial amount cannot be less than 1000");
                        return;
                    }
                    init_amount = value;
                }
                get
                {
                    return init_amount;
                }
            }
            public static float InterestRate
        {
            private set { interest = value; }
            get {  return interest; }
        }
        public Accounts() 
        {
            this.InitialAmount = 10000;
        }
        public Accounts(float atm)
        {
            this.InitialAmount = atm;
        }
        static Accounts()
        {
            Accounts.InterestRate = 9.5F;
        }

        }
}
