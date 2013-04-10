using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2350_FinalProject_Team4
{
    class Reliability
    {

        private static int reliabilityRating;
        private static string inValue;

        public Reliability()
        {
        }

        public static int ReliabilityRating
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

        public static void getReliabilityRating()
        {
            Console.Write("Are you Reliable?Please answer No or Yes\n");
            inValue = Console.ReadLine();

            switch (inValue)
            {
                case "Yes":
                case "yes":
                case "YES":
                    reliabilityRating = 1;

                    break;
                case "No":
                case "no":
                case "NO":
                case "nO":
                    reliabilityRating = 0;

                    break;
            }
        }
    }

}
