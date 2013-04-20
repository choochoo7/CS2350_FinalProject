using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2350_FinalProject_Team4
{
    class Reliability
    {

        private int reliabilityRating;
        private static string inValue;

        public Reliability()
        {
            this.reliabilityRating = getReliabilityRating();
        }

        public int ReliabilityRating
        {
            get
            {
                return reliabilityRating;
            }

            set
            {
                reliabilityRating = value;
            }
        }

        //get characteristic rating from user
        public static int getReliabilityRating()
        {
            int charRate = 3;
            int userInput;

            Graphics.HonestFont();

            Console.SetCursorPosition(20, 22);
            Console.Write("Are you Reliable? Enter 1 for No, or 2 for Yes\n");
            Console.SetCursorPosition(35, 27);
            inValue = Console.ReadLine();
            //send input to error check before assigning
            userInput = Client.intCheck(inValue, 1);
            Console.Clear();

            switch (userInput)
            {
                case 1: //no
                    charRate = 1;

                    break;
                case 2: //yes
                    charRate = 2;

                    break;
            }
            return charRate;
        }   //close getReliabilityRating

    }   //close CLass

}   //close Namespace
