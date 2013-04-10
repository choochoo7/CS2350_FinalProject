using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2350_FinalProject_Team4
{
    class Patience
    {
        private static int patienceRating;
        private static string inValue;

        public Patience()
        {
        }

        public static int PatienceRating
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


        public static void getPatienceRating()
        {
            Console.Write("Are you Patient?Please answer No or Yes\n");
            inValue = Console.ReadLine();

            switch (inValue)
            {
                case "Yes":
                case "yes":
                case "YES":
                    patienceRating = 1;

                    break;
                case "No":
                case "no":
                case "NO":
                case "nO":
                    patienceRating = 0;

                    break;
            }
        }
    }

}
