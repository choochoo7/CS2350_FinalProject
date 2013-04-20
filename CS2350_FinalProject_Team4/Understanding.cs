using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2350_FinalProject_Team4
{
    class Understanding
    {
        private int understandingRating;
        private static string inValue;

        public Understanding()
        {
            this.understandingRating = getUnderstandingRating();
        }

        public int UnderstandingRating
        {
            get
            {
                return understandingRating;
            }

            set
            {
                understandingRating = value;
            }
        }

        //get characteristic rating from user
        public static int getUnderstandingRating()
        {
            int charRate = 3;
            int userInput;

            Graphics.UnderstandFont();

            Console.SetCursorPosition(0, 22);
            Console.Write("Your best friend confesses that he/she borrowed your car to run to the grocery store for" +
                " an emergency ice cream run. Someone keyed the car while he/she was there. " +
                "Do you (1) flip out and find a new best friend or (2) try calm down and empathize;"+
                " ice cream does sound pretty good.\n");
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
        }   //close getUnderstandingRating

    }   //close CLass

}   //close Namespace
