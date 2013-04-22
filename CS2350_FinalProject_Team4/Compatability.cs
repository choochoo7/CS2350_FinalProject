using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CS2350_FinalProject_Team4
{
    class Compatability
    {
        private static Random randomBust = new Random();

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
            String client2bio = "I'm just your average guy. I like long walks on the beach, dogs, and "
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
                   + " a girl I can really commit to.";


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
                    + " The sun plays me on TV. Need I say more?";

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
            String client5bio = "I signed up for this because it's cheaper than LifeAlert; if I fall and can't get up, I'll just "
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
            " But I have 20 cats that can't wait to meet you!";

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
                    + "get married. I have the ring picked out, you can pick it up at "
                  + "Tiffany's";

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

            //set max value to array high value
            int maxValue = compatArray.Max();
            int maxIndex = Array.IndexOf(compatArray, maxValue);

            //randomizer for occasional no match scene
            int busted = Convert.ToInt32(randomBust.Next(5));
            if (busted == 4)
                maxIndex = 10;

            Thread.Sleep(1000);
            Console.SetCursorPosition(22, 18);
            Console.WriteLine("We have finished our tabulations....");
            Sound.DrumRollMusic();
            Thread.Sleep(1000);
            Console.SetCursorPosition(22, 22);
            Console.WriteLine("Press a key to find out what's in store for you...");
            Console.ReadKey();
            Console.Clear();
            //reset graphics to white/DkRed
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            switch (maxIndex)
            {
                case 0:
                    Sound.MatchMusic();
                    Thread.Sleep(1000);
                    Graphics.MatchFont();
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(22, 14);
                    Console.Write("You have a match!");
                    Console.SetCursorPosition(26, 18);
                    Console.Write("His name is: " + john[1] + " " + john[2]);
                    Console.SetCursorPosition(26, 20);
                    Console.Write("He's " + john[3] + " years old.");
                    Console.SetCursorPosition(26, 22);
                    Console.Write("He's got " + john[4] + " hair.");
                    Console.SetCursorPosition(26, 24);
                    Console.Write("He's " + john[5] + " inches tall.");
                    Console.SetCursorPosition(2, 27);
                    Console.Write("Here's what " + john[1] + " had to say about himself: " + client1bio);
                    break;
                case 1:
                    Sound.MatchMusic();
                    Thread.Sleep(1000);
                    Graphics.MatchFont();
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(22, 14);
                    Console.Write("You have a match!");
                    Console.SetCursorPosition(26, 18);
                    Console.Write("His name is: " + jason[1] + " " + jason[2]);
                    Console.SetCursorPosition(26, 20);
                    Console.Write("He's " + jason[3] + " years old.");
                    Console.SetCursorPosition(26, 22);
                    Console.Write("He's got " + jason[4] + " hair.");
                    Console.SetCursorPosition(26, 24);
                    Console.Write("He's " + jason[5] + " inches tall.");
                    Console.SetCursorPosition(2, 27);
                    Console.Write("Here's what " + jason[1] + " had to say about himself: " + client2bio);
                    break;
                case 2:
                    Sound.MatchMusic();
                    Thread.Sleep(1000);
                    Graphics.MatchFont();
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(22, 14);
                    Console.Write("You have a match!");
                    Console.SetCursorPosition(26, 18);
                    Console.Write("His name is: " + brad[1] + " " + brad[2]);
                    Console.SetCursorPosition(26, 20);
                    Console.Write("He's " + brad[3] + " years old.");
                    Console.SetCursorPosition(26, 22);
                    Console.Write("He's got " + brad[4] + " hair.");
                    Console.SetCursorPosition(26, 24);
                    Console.Write("He's " + brad[5] + " inches tall.");
                    Console.SetCursorPosition(2, 27);
                    Console.Write("Here's what " + brad[1] + " had to say about himself: " + client3bio);
                    break;
                case 3:
                    Sound.MatchMusic();
                    Thread.Sleep(1000);
                    Graphics.MatchFont();
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(22, 14);
                    Console.Write("You have a match!");
                    Console.SetCursorPosition(26, 18);
                    Console.Write("His name is: " + jimmy[1] + " " + jimmy[2]);
                    Console.SetCursorPosition(26, 20);
                    Console.Write("He's " + jimmy[3] + " years old.");
                    Console.SetCursorPosition(26, 22);
                    Console.Write("He's got " + jimmy[4] + " hair.");
                    Console.SetCursorPosition(26, 24);
                    Console.Write("He's " + jimmy[5] + " inches tall.");
                    Console.SetCursorPosition(2, 27);
                    Console.Write("Here's what " + jimmy[1] + " had to say about himself: " + client4bio);
                    break;
                case 4:
                    Sound.MatchMusic();
                    Thread.Sleep(1000);
                    Graphics.MatchFont();
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(22, 14);
                    Console.Write("You have a match!");
                    Console.SetCursorPosition(26, 18);
                    Console.Write("His name is: " + fred[1] + " " + fred[2]);
                    Console.SetCursorPosition(26, 20);
                    Console.Write("He's " + fred[3] + " years old.");
                    Console.SetCursorPosition(26, 22);
                    Console.Write("He's got " + fred[4] + " hair.");
                    Console.SetCursorPosition(26, 24);
                    Console.Write("He's " + fred[5] + " inches tall.");
                    Console.SetCursorPosition(2, 27);
                    Console.Write("Here's what " + fred[1] + " had to say about himself: " + client5bio);
                    break;
                case 5:
                    Sound.MatchMusic();
                    Thread.Sleep(1000);
                    Graphics.MatchFont();
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(22, 14);
                    Console.Write("You have a match!");
                    Console.SetCursorPosition(26, 18);
                    Console.Write("Her name is: " + jennifer[1] + " " + jennifer[2]);
                    Console.SetCursorPosition(26, 20);
                    Console.Write("She's " + jennifer[3] + " years old.");
                    Console.SetCursorPosition(26, 22);
                    Console.Write("She's got " + jennifer[4] + " hair.");
                    Console.SetCursorPosition(26, 24);
                    Console.Write("She's " + jennifer[5] + " inches tall.");
                    Console.SetCursorPosition(2, 27);
                    Console.Write("Here's what " + jennifer[1] + " had to say about herself: " + client6bio);
                    break;
                case 6:
                    Sound.MatchMusic();
                    Thread.Sleep(1000);
                    Graphics.MatchFont();
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(22, 14);
                    Console.Write("You have a match!");
                    Console.SetCursorPosition(26, 18);
                    Console.Write("Her name is: " + susan[1] + " " + susan[2]);
                    Console.SetCursorPosition(26, 20);
                    Console.Write("She's " + susan[3] + " years old.");
                    Console.SetCursorPosition(26, 22);
                    Console.Write("She's got " + susan[4] + " hair.");
                    Console.SetCursorPosition(26, 24);
                    Console.Write("She's " + susan[5] + " inches tall.");
                    Console.SetCursorPosition(2, 27);
                    Console.Write("Here's what " + susan[1] + " had to say about herself: " + client7bio);
                    break;
                case 7:
                    Sound.MatchMusic();
                    Thread.Sleep(1000);
                    Graphics.MatchFont();
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(22, 14);
                    Console.Write("You have a match!");
                    Console.SetCursorPosition(26, 18);
                    Console.Write("Her name is: " + angelina[1] + " " + angelina[2]);
                    Console.SetCursorPosition(26, 20);
                    Console.Write("She's " + angelina[3] + " years old.");
                    Console.SetCursorPosition(26, 22);
                    Console.Write("She's got " + angelina[4] + " hair.");
                    Console.SetCursorPosition(26, 24);
                    Console.Write("She's " + angelina[5] + " inches tall.");
                    Console.SetCursorPosition(2, 27);
                    Console.Write("Here's what " + angelina[1] + " had to say about herself: " + client8bio);
                    break;
                case 8:
                    Sound.MatchMusic();
                    Thread.Sleep(1000);
                    Graphics.MatchFont();
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(22, 14);
                    Console.Write("You have a match!");
                    Console.SetCursorPosition(26, 18);
                    Console.Write("Her name is: " + thelma[1] + " " + thelma[2]);
                    Console.SetCursorPosition(26, 20);
                    Console.Write("She's " + thelma[3] + " years old.");
                    Console.SetCursorPosition(26, 22);
                    Console.Write("She's got " + thelma[4] + " hair.");
                    Console.SetCursorPosition(26, 24);
                    Console.Write("She's " + thelma[5] + " inches tall.");
                    Console.SetCursorPosition(2, 27);
                    Console.Write("Here's what " + thelma[1] + " had to say about herself: " + client9bio);
                    break;
                case 9:
                    Sound.MatchMusic();
                    Thread.Sleep(1000);
                    Graphics.MatchFont();
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(22, 14);
                    Console.Write("You have a match!");
                    Console.SetCursorPosition(26, 18);
                    Console.Write("Her name is: " + rose[1] + " " + rose[2]);
                    Console.SetCursorPosition(26, 20);
                    Console.Write("She's " + rose[3] + " years old.");
                    Console.SetCursorPosition(26, 22);
                    Console.Write("She's got " + rose[4] + " hair.");
                    Console.SetCursorPosition(26, 24);
                    Console.Write("She's " + rose[5] + " inches tall.");
                    Console.SetCursorPosition(2, 27);
                    Console.Write("Here's what " + rose[1] + " had to say about herself: " + client10bio);
                    break;
                default:
                    //no match scene
                    Graphics.SoSorryConsole();
                    Graphics.SoSorryFont();
                    break;
            }
            Thread.Sleep(8000);
            Console.SetCursorPosition(24, 34);
            Console.WriteLine("Click a key to keep on movin'...");
            Console.ReadKey(true);
        }


    }   //close Class
}   //close Namespace
