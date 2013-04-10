using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2350_FinalProject_Team4
{
    class Understanding
    {
        private static int understandingRating;
        private static string inValue;

        public Understanding()
        {
        }

        public static int UnderstandingRating
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

        public static void getUnderstandingRating()
        {
            Console.Write("Are you Understanding?Please answer No or Yes\n");
            inValue = Console.ReadLine();

            switch (inValue)
            {
                case "Yes":
                case "yes":
                case "YES":
                    understandingRating = 1;

                    break;
                case "No":
                case "no":
                case "NO":
                case "nO":
                    understandingRating = 0;

                    break;
            }
        }
    }

}
