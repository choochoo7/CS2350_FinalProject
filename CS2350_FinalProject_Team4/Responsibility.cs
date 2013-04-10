using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2350_FinalProject_Team4
{
    class Responsibility
    {
        private static int responsibilityRating;
        private static string inValue;


        public Responsibility()
        {
        }

        public static int ResponsibilityRating
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

        public static void getResponsibilityRating()
        {
            Console.Write("Are you Responsible?Please answer No or Yes\n");
            inValue = Console.ReadLine();

            switch (inValue)
            {
                case "Yes":
                case "yes":
                case "YES":
                    responsibilityRating = 1;

                    break;
                case "No":
                case "no":
                case "NO":
                case "nO":
                    responsibilityRating = 0;

                    break;
            }
        }

    }

}
