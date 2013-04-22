using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2350_FinalProject_Team4
{
    class Adaptability
    {
        private int adaptabilityRating;
        private static string inValue;
        // Constructor
        public Adaptability()
        {
            this.adaptabilityRating = getAdaptabilityRating();
        }
        // property
        public int AdaptabilityRating
        {
            get
            {
                return adaptabilityRating;
            }

            set
            {
                adaptabilityRating = value;
            }
        }

        //get characteristic rating from user
        public static int getAdaptabilityRating()
        {
            int charRate = 3;
            int userInput;
            // Calls the AdaptableFront method in the Graphics Class
            Graphics.AdaptableFont();
            // Adaptability question
            Console.SetCursorPosition(0, 18);
            Console.Write("   Your job asks you to move to Germany. Do you:");
            Console.SetCursorPosition(10, 22);
            Console.Write("(1) fight the move: you're happy where you are, and you hate change");
            Console.SetCursorPosition(14, 24);
            Console.Write("OR");
            Console.SetCursorPosition(10, 26);
            Console.Write("(2) embrace the move: you're excited to try new experiences and embrace");
            Console.SetCursorPosition(10, 27);
            Console.Write("a new lifestyle");
            Console.SetCursorPosition(35, 30);
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
        }   //close getAdaptabilityRating

    }   //close CLass

}   //close Namespace
