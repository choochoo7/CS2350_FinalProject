using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2350_FinalProject_Team4
{
    class Honesty
    {
        private static int honestyRating;
        private static string inValue;

        public Honesty()
        {
        }


        public static int HonestyRating
        {
            get
            {
                return honestyRating;
            }

            set
            {
                honestyRating = value;
            }
        }

        public static void getHonestyRating()
        {
            Console.Write("Are you Honest?Please answer No or Yes\n");
            inValue = Console.ReadLine();

            switch (inValue)
            {
                case "Yes":
                case "yes":
                case "YES":
                    HonestyRating = 1;

                    break;
                case "No":
                case "no":
                case "NO":
                case "nO":
                    honestyRating = 0;

                    break;
            }

        }

    }

}
