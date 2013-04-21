using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS2350_FinalProject_Team4
{
    class Compatability
    {

        ArrayList compareClient;

        public Compatability(ArrayList aClient)
        {
            compareClient = aClient;
            Comparison(aClient);
        }
        public static void Comparison(ArrayList anArrayList)
        {
            ArrayList bestMatch = new ArrayList();

            int[] compatArray = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            ArrayList john = new ArrayList();
            john.Add(2);
            john.Add("John");
            john.Add("Smith");
            john.Add(30);
            john.Add("Blonde");
            john.Add(72);
            john.Add(1);
            john.Add(1);
            john.Add(1);
            john.Add(1);
            john.Add(1);
            john.Add(1);
            john.Add(1);
            String client1bio = "I'm looking for someone to show me"
            + "\nhow to paint with all the colors of the wind.";

            ArrayList jason = new ArrayList();
            jason.Add(2);
            jason.Add("Jason");
            jason.Add("Miller");
            jason.Add(42);
            jason.Add("Brown");
            jason.Add(77);
            jason.Add(2);
            jason.Add(2);
            jason.Add(2);
            jason.Add(2);
            jason.Add(1);
            jason.Add(2);
            jason.Add(1);
            String client2bio = "I'm just your average guy. I like long walks on the beach, dogs,\nand "
                    + "watching football on Sundays. ";

            ArrayList brad = new ArrayList();
            brad.Add(2);
            brad.Add("Brad");
            brad.Add("Jones");
            brad.Add(25);
            brad.Add("Black");
            brad.Add(63);
            brad.Add(1);
            brad.Add(2);
            brad.Add(1);
            brad.Add(1);
            brad.Add(2);
            brad.Add(1);
            brad.Add(1);
            String client3bio = "I've changed my major seven times, but I'm looking for"
                   + "\na girl I can really commit to.";


            ArrayList jimmy = new ArrayList();
            jimmy.Add(2);
            jimmy.Add("Jimmy");
            jimmy.Add("Dean");
            jimmy.Add(66);
            jimmy.Add("White");
            jimmy.Add(52);
            jimmy.Add(2);
            jimmy.Add(1);
            jimmy.Add(2);
            jimmy.Add(2);
            jimmy.Add(1);
            jimmy.Add(2);
            jimmy.Add(1);
            String client4bio = "I own a line of breakfast foods."
                    + "\nThe sun plays me on TV. Need I say more?";

            ArrayList fred = new ArrayList();
            fred.Add(2);
            fred.Add("Fred");
            fred.Add("McIntyre");
            fred.Add(78);
            fred.Add("Grey");
            fred.Add(69);
            fred.Add(2);
            fred.Add(2);
            fred.Add(2);
            fred.Add(2);
            fred.Add(2);
            fred.Add(2);
            fred.Add(2);
            String client5bio = "I signed up for this because it's cheaper than LifeAlert; \nif I fall and can't get up, I'll just "
                                + "call you!";

            ArrayList jennifer = new ArrayList();
            jennifer.Add(1);
            jennifer.Add("Jennifer");
            jennifer.Add("Williams");
            jennifer.Add(33);
            jennifer.Add("Red");
            jennifer.Add(62);
            jennifer.Add(2);
            jennifer.Add(2);
            jennifer.Add(2);
            jennifer.Add(2);
            jennifer.Add(2);
            jennifer.Add(2);
            jennifer.Add(2);
            String client6bio = "I don't like pina coladas. Or getting caught in the rain." +
            " \nBut I have 20 cats that can't wait to meet you!";

            ArrayList susan = new ArrayList();
            susan.Add(1);
            susan.Add("Susan");
            susan.Add("Davis");
            susan.Add(39);
            susan.Add("Blonde");
            susan.Add(65);
            susan.Add(1);
            susan.Add(2);
            susan.Add(1);
            susan.Add(1);
            susan.Add(1);
            susan.Add(2);
            susan.Add(2);
            String client7bio = "I have a detailed 10 year plan; this year I'm supposed to "
                    + "\nget married. I have the ring picked out, you can pick it up at"
                  + "\nTiffany's";

            ArrayList angelina = new ArrayList();
            angelina.Add(1);
            angelina.Add("Angelina Jolie");
            angelina.Add("Jolie");
            angelina.Add(40);
            angelina.Add("Brown");
            angelina.Add(67);
            angelina.Add(2);
            angelina.Add(1);
            angelina.Add(2);
            angelina.Add(2);
            angelina.Add(2);
            angelina.Add(1);
            angelina.Add(1);
            String client8bio = "Brad Pitt got boring. Be ready to adopt!";

            ArrayList thelma = new ArrayList();
            thelma.Add(1);
            thelma.Add("Thelma");
            thelma.Add("O'Malley");
            thelma.Add(79);
            thelma.Add("White");
            thelma.Add(48);
            thelma.Add(2);
            thelma.Add(1);
            thelma.Add(1);
            thelma.Add(1);
            thelma.Add(1);
            thelma.Add(2);
            thelma.Add(1);
            String client9bio = "I'm to old to take any crap from anyone. Hit me up for a good time!";

            ArrayList rose = new ArrayList();
            rose.Add(1);
            rose.Add("Rose");
            rose.Add("Meyers");
            rose.Add(82);
            rose.Add("White");
            rose.Add(52);
            rose.Add(1);
            rose.Add(1);
            rose.Add(1);
            rose.Add(1);
            rose.Add(1);
            rose.Add(1);
            rose.Add(1);
            String client10bio = "Is this where you twitter? Or is this the Face Book?";

            for (int i = 6; i <= 12; i++)
            {
                if (anArrayList[0].ToString() == jennifer[0].ToString())
                {
                    if (anArrayList[i].ToString() == john[i].ToString())
                        compatArray[0] += 1;
                    if (anArrayList[i].ToString() == jason[i].ToString())
                        compatArray[1] += 1;
                    if (anArrayList[i].ToString() == brad[i].ToString())
                        compatArray[2] += 1;
                    if (anArrayList[i].ToString() == jimmy[i].ToString())
                        compatArray[3] += 1;
                    if (anArrayList[i].ToString() == fred[i].ToString())
                        compatArray[4] += 1;
                }
                else if (anArrayList[0].ToString() == john[0].ToString())
                {
                    if (anArrayList[i].ToString() == jennifer[i].ToString())
                        compatArray[5] += 1;
                    if (anArrayList[i].ToString() == susan[i].ToString())
                        compatArray[6] += 1;
                    if (anArrayList[i].ToString() == angelina[i].ToString())
                        compatArray[7] += 1;
                    if (anArrayList[i].ToString() == thelma[i].ToString())
                        compatArray[8] += 1;
                    if (anArrayList[i].ToString() == rose[i].ToString())
                        compatArray[9] += 1;
                }
            }
            int maxValue = compatArray.Max();
            int maxIndex = Array.IndexOf(compatArray, maxValue);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            switch (maxIndex)
            {
                case 0: Console.WriteLine("You have a match!" + "\nName: " + john[1] + " " +
                                            john[2] + "\nAge: " + john[3] + "\nHair Color: " + john[4]
                                            + "\nHeight: " + john[5] + " inches" + "\n\n" + "Bio: " + client1bio);
                    break;
                case 1: Console.WriteLine("You have a match!" + "\nName: " + jason[1] + " " +
                                            jason[2] + "\nAge: " + jason[3] + "\nHair Color: " + jason[4]
                                            + "\nHeight: " + jason[5] + " inches" + "\n\n" + "Bio: " + client2bio);
                    break;
                case 2: Console.WriteLine("You have a match!" + "\nName: " + brad[1] + " " +
                                            brad[2] + "\nAge: " + brad[3] + "\nHair Color: " + brad[4]
                                            + "\nHeight: " + brad[5] + " inches" + "\n\n" + "Bio: " + client3bio);
                    break;
                case 3: Console.WriteLine("You have a match!" + "\nName: " + jimmy[1] + " " +
                                            jimmy[2] + "\nAge: " + jimmy[3] + "\nHair Color: " + jimmy[4]
                                            + "\nHeight: " + jimmy[5] + " inches" + "\n\n" + "Bio: " + client4bio);
                    break;
                case 4: Console.WriteLine("You have a match!" + "\nName: " + fred[1] + " " +
                                            fred[2] + "\nAge: " + fred[3] + "\nHair Color: " + fred[4]
                                            + "\nHeight: " + fred[5] + " inches" + "\n\n" + "Bio: " + client5bio);
                    break;
                case 5: Console.WriteLine("You have a match!" + "\nName: " + jennifer[1] + " " +
                                            jennifer[2] + "\nAge: " + jennifer[3] + "\nHair Color: " + jennifer[4]
                                            + "\nHeight: " + jennifer[5] + " inches" + "\n\n" + "Bio: " + client6bio);
                    break;
                case 6: Console.WriteLine("You have a match!" + "\nName: " + susan[1] + " " +
                                            susan[2] + "\nAge: " + susan[3] + "\nHair Color: " + susan[4]
                                            + "\nHeight: " + susan[5] + " inches" + "\n\n" + "Bio: " + client7bio);
                    break;
                case 7: Console.WriteLine("You have a match!" + "\nName: " + angelina[1] + " " +
                                            angelina[2] + "\nAge: " + angelina[3] + "\nHair Color: " + angelina[4]
                                            + "\nHeight: " + angelina[5] + " inches" + "\n\n" + "Bio: " + client8bio);
                    break;
                case 8: Console.WriteLine("You have a match!" + "\nName: " + thelma[1] + " " +
                                            thelma[2] + "\nAge: " + thelma[3] + "\nHair Color: " + thelma[4]
                                            + "\nHeight: " + thelma[5] + " inches" + "\n\n" + "Bio: " + client9bio);
                    break;
                case 9: Console.WriteLine("You have a match!" + "\nName: " + rose[1] + " " +
                                            rose[2] + "\nAge: " + rose[3] + "\nHair Color: " + rose[4]
                                            + "\nHeight: " + rose[5] + " inches" + "\n\n" + "Bio: " + client10bio);
                    break;
                default: Console.WriteLine("No match for you...Buy a few cats?");
                    break;
            }
        }


    }   //close Class
}   //close Namespace
