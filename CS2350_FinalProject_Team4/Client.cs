using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2350_FinalProject_Team4
{
    class Client
    {
        // private int clientNumber;
        private static int gender;
        private static string firstName;
        private static string lastName;
        private static int age;
        private static string hairColor;
        private static double height;
        private static int honest;
        private static int responsible;
        private static int Adaptable;
        private static int Understand;
        private static int patient;
        private static int Reliable;
        private static int boldness;

        // this is a no - agrument constructor
        public Client()
        {


            // These methods test if the questions are displayed in the console
            /*
            getGender();
            getFirstName();
            getLastName();
            getAge();
            getHairColor();
            
            Resp();
            Rely();
            Honest();
            Patient();
            Adap();
             */
        }

        public static int getGender()
        {
            string inValue;
            Console.Write("Please enter 1 for Female or 2 for Male:\n");

            inValue = Console.ReadLine();
            gender = int.Parse(inValue);

            return gender;
        }

        public static string getFirstName()
        {

            Console.Write("Please enter your first name:\n");
            firstName = Console.ReadLine();

            return firstName;
        }

        public static string getLastName()
        {
            Console.Write("Please enter your last name:\n");
            lastName = Console.ReadLine();

            return lastName;
        }

        public static int getAge()
        {
            string inValue;
            Console.Write("Please enter your Age:\n");
            inValue = Console.ReadLine();
            age = int.Parse(inValue);
            return age;
        }

        public static string getHairColor()
        {
            Console.Write("Please enter your hair color:\n");
            hairColor = Console.ReadLine();

            return hairColor;
        }

        public static double getHeight()
        {
            string inValue;
            Console.Write("Please enter your height:\n");
            inValue = Console.ReadLine();
            height = double.Parse(inValue);
            return height;
        }

        public static int Honest()
        {
            Honesty.getHonestyRating();
            honest = Honesty.HonestyRating;
            return honest;
        }

        public static int Resp()
        {
            Responsibility.getResponsibilityRating();
            responsible = Responsibility.ResponsibilityRating;

            return responsible;
        }

        public static int Adap()
        {
            Adaptability.getAdaptabilityRating();
            Adaptable = Adaptability.AdaptabilityRating;

            return Adaptable;
        }

        public static int Unders()
        {
            Understanding.getUnderstandingRating();
            Understand = Understanding.UnderstandingRating;

            return Understand;

        }
        public static int Bold()
        {
            Boldness.getBoldnessRating();
            boldness = Boldness.BoldnessRating;

            return boldness;
        }

        public static int Patient()
        {
            Patience.getPatienceRating();
            patient = Patience.PatienceRating;

            return patient;
        }

        public static int Rely()
        {
            Reliability.getReliabilityRating();
            Reliable = Reliability.ReliabilityRating;

            return Reliable;
        }
    }

}
