using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2350_FinalProject_Team4
{
    class Patience
    {
        private int patienceRating;
        private static string inValue;

        public Patience()
        {
            this.patienceRating = getPatienceRating();
        }

        public int PatienceRating
        {
            get
            {
                return patienceRating;
            }

            set
            {
                patienceRating = value;
            }
        }

        //get characteristic rating from user
        public static int getPatienceRating()
        {
            int charRate = 3;
            int userInput;

            Graphics.PatientFont();

            Console.SetCursorPosition(0, 18);
            Console.Write("   Are you:");
            Console.SetCursorPosition(10, 22);
            Console.Write("(1) patient enough to watch grass grow or paint dry?");
            Console.SetCursorPosition(14, 24);
            Console.Write("OR");
            Console.SetCursorPosition(10, 26);
            Console.Write("(2) unable to wait the minute and a half to pop popcorn in the microwave.");
            Console.SetCursorPosition(10, 27);
            Console.Write("Even though the other kind tastes better, you buy the pre-popped");
            Console.SetCursorPosition(10, 28);
            Console.Write("kind to avoid the wait.");
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
        }   //close getPatienceRating

    }   //close CLass

}   //close Namespace
