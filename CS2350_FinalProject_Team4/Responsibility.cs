using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2350_FinalProject_Team4
{
    class Responsibility
    {
        private int responsibilityRating;
        private static string inValue;


        public Responsibility()
        {
            this.responsibilityRating = getResponsibilityRating();
        }

        public int ResponsibilityRating
        {
            get
            {
                return responsibilityRating;
            }

            set
            {
                responsibilityRating = value;
            }
        }

        //get characteristic rating from user
        public static int getResponsibilityRating()
        {
            int charRate = 3;
            int userInput;

            Graphics.ResponsibleFont();

            Console.SetCursorPosition(0, 22);
             Console.Write("Your friend gives you a fish to take care of for a few weeks. " +
                "At the end of the \nfish's stay is it (1) floating upside down in a sea of" +
                " algae and unidentified floating objects, or (2) healthy and happy?\n");
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
        }   //close getResponsibilityRating

    }   //close CLass

}   //close Namespace
