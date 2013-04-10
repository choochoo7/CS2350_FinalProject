using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2350_FinalProject_Team4
{
    class Boldness
    {
        private static int boldnessRating;
        private static string inValue;

        public Boldness()
        {
        }

        public static int BoldnessRating
        {
            get
            {
                return boldnessRating;
            }

            set
            {
                boldnessRating = value;
            }
        }

        public static void getBoldnessRating()
        {
            Console.Write("Are you Bold?Please answer No or Yes\n");
            inValue = Console.ReadLine();

            switch (inValue)
            {
                case "Yes":
                case "yes":
                case "YES":
                    boldnessRating = 1;

                    break;
                case "No":
                case "no":
                case "NO":
                case "nO":
                    boldnessRating = 0;

                    break;
            }
        }
    }

}
