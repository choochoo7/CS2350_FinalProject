using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2350_FinalProject_Team4
{
    class Adaptability
    {
        private static int adaptabilityRating;
        private static string inValue;

        public Adaptability()
        {
        }

        public static int AdaptabilityRating
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

        public static void getAdaptabilityRating()
        {
            Console.Write("Are you Adaptable?Please answer No or Yes\n");
            inValue = Console.ReadLine();

            switch (inValue)
            {
                case "Yes":
                case "yes":
                case "YES":
                    adaptabilityRating = 1;

                    break;
                case "No":
                case "no":
                case "NO":
                case "nO":
                    adaptabilityRating = 0;

                    break;
            }
        }
    }
}
