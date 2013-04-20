using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace CS2350_FinalProject_Team4
{
    class Graphics
    {
        //Thread Sleep() will be used to slow console write speed for a better user experience


        public Graphics()
        {
        }

        public static void ConsoleBasics()
        {
            //alter console graphics and measurements
            Console.Title = "CS2350 Final Project - Group 4";
            Console.SetWindowSize(85, 43);
            Console.CursorVisible = false;
            Console.Clear();
        }

        public static void ConsoleIntro()
        {
            //opening sequece colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void GenderConsole()
        {
            Console.Clear();
            Console.SetCursorPosition(21, 12);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(@"--/-<@  Welcome to the Dating App!  @>-\---");
            Console.SetCursorPosition(21, 22);
        }

        public static void MaleConsole()
        {

            Console.Title = @"--/-<@  The Dating App!  @>-\---";
            //gender sequece colors
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(21, 22);

        }

        public static void FemaleConsole()
        {

            Console.Title = @"--/-<@  The Dating App!  @>-\---";
            //gender sequece colors
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetCursorPosition(21, 22);
        }

        public static void HonestFont()
        {
            Console.WriteLine(@"   _   _                       _   ");
            Console.WriteLine(@"  | | | | ___  _ __   ___  ___| |_ ");
            Console.WriteLine(@"  | |_| |/ _ \| '_ \ / _ \/ __| __|");
            Console.WriteLine(@"  |  _  | (_) | | | |  __/\__ \ |_ ");
            Console.WriteLine(@"  |_| |_|\___/|_| |_|\___||___/\__|");
        }

        public static void ResponsibleFont()
        {
            Console.WriteLine(@"   ____                                 _ _     _      ");
            Console.WriteLine(@"  |  _ \ ___  ___ _ __   ___  _ __  ___(_) |__ | | ___ ");
            Console.WriteLine(@"  | |_) / _ \/ __| '_ \ / _ \| '_ \/ __| | '_ \| |/ _ \");
            Console.WriteLine(@"  |  _ <  __/\__ \ |_) | (_) | | | \__ \ | |_) | |  __/");
            Console.WriteLine(@"  |_| \_\___||___/ .__/ \___/|_| |_|___/_|_.__/|_|\___|");
            Console.WriteLine(@"                 |_|                                   ");
        }

        public static void AdaptableFont()
        {

            Console.WriteLine(@"      _       _             _        _     _      ");
            Console.WriteLine(@"     / \   __| | __ _ _ __ | |_ __ _| |__ | | ___ ");
            Console.WriteLine(@"    / _ \ / _` |/ _` | '_ \| __/ _` | '_ \| |/ _ \");
            Console.WriteLine(@"   / ___ \ (_| | (_| | |_) | || (_| | |_) | |  __/");
            Console.WriteLine(@"  /_/   \_\__,_|\__,_| .__/ \__\__,_|_.__/|_|\___|");
            Console.WriteLine(@"                     |_|                          ");

        }

        public static void UnderstandFont()
        {
            Console.WriteLine(@"   _   _           _               _                  _ _             ");
            Console.WriteLine(@"  | | | |_ __   __| | ___ _ __ ___| |_ __ _ _ __   __| (_)_ __   __ _ ");
            Console.WriteLine(@"  | | | | '_ \ / _` |/ _ \ '__/ __| __/ _` | '_ \ / _` | | '_ \ / _` |");
            Console.WriteLine(@"  | |_| | | | | (_| |  __/ |  \__ \ || (_| | | | | (_| | | | | | (_| |");
            Console.WriteLine(@"   \___/|_| |_|\__,_|\___|_|  |___/\__\__,_|_| |_|\__,_|_|_| |_|\__, |");
            Console.WriteLine(@"                                                                |___/ ");
        }

        public static void PatientFont()
        {
            Console.WriteLine(@"   ____       _   _            _   ");
            Console.WriteLine(@"  |  _ \ __ _| |_(_) ___ _ __ | |_ ");
            Console.WriteLine(@"  | |_) / _` | __| |/ _ \ '_ \| __|");
            Console.WriteLine(@"  |  __/ (_| | |_| |  __/ | | | |_ ");
            Console.WriteLine(@"  |_|   \__,_|\__|_|\___|_| |_|\__|");
        }

        public static void ReliableFont()
        {
            Console.WriteLine(@"   ____      _ _       _     _      ");
            Console.WriteLine(@"  |  _ \ ___| (_) __ _| |__ | | ___ ");
            Console.WriteLine(@"  | |_) / _ \ | |/ _` | '_ \| |/ _ \");
            Console.WriteLine(@"  |  _ <  __/ | | (_| | |_) | |  __/");
            Console.WriteLine(@"  |_| \_\___|_|_|\__,_|_.__/|_|\___|");
        }

        public static void BoldFont()
        {
            Console.WriteLine(@"   ____        _     _ ");
            Console.WriteLine(@"  | __ )  ___ | | __| |");
            Console.WriteLine(@"  |  _ \ / _ \| |/ _` |");
            Console.WriteLine(@"  | |_) | (_) | | (_| |");
            Console.WriteLine(@"  |____/ \___/|_|\__,_|");
        }





        public static void HeartsMoving()
        {
            int movement = 1;

            Thread.Sleep(2000);
            while (movement < 3)
            {
                switch (movement)
                {
                    case 1:
                        for (int i = 1; i < 73; i++)
                        {
                            Console.SetCursorPosition(i, 2);
                            Console.WriteLine("  **    **  ");
                            Console.SetCursorPosition(i, 3);
                            Console.WriteLine(" ****  **** ");
                            Console.SetCursorPosition(i, 4);
                            Console.WriteLine("************");
                            Console.SetCursorPosition(i, 5);
                            Console.WriteLine(" ********** ");
                            Console.SetCursorPosition(i, 6);
                            Console.WriteLine("  ********  ");
                            Console.SetCursorPosition(i, 7);
                            Console.WriteLine("   ******   ");
                            Console.SetCursorPosition(i, 8);
                            Console.WriteLine("    ****    ");
                            Console.SetCursorPosition(i, 9);
                            Console.WriteLine("     **     ");


                            Console.SetCursorPosition((73 - i), 35);
                            Console.WriteLine("  **    **  ");
                            Console.SetCursorPosition((73 - i), 36);
                            Console.WriteLine(" ****  **** ");
                            Console.SetCursorPosition((73 - i), 37);
                            Console.WriteLine("************");
                            Console.SetCursorPosition((73 - i), 38);
                            Console.WriteLine(" ********** ");
                            Console.SetCursorPosition((73 - i), 39);
                            Console.WriteLine("  ********  ");
                            Console.SetCursorPosition((73 - i), 40);
                            Console.WriteLine("   ******   ");
                            Console.SetCursorPosition((73 - i), 41);
                            Console.WriteLine("    ****    ");
                            Console.SetCursorPosition((73 - i), 42);
                            Console.WriteLine("     **     ");
                            Thread.Sleep(60);
                            Console.Clear();
                        }
                        movement++;
                        break;
                    case 2:
                        for (int i = 1; i < 31; i++)
                        {
                            Console.SetCursorPosition(i, 18);
                            Console.WriteLine("  **    **  ");
                            Console.SetCursorPosition(i, 19);
                            Console.WriteLine(" ****  **** ");
                            Console.SetCursorPosition(i, 20);
                            Console.WriteLine("************");
                            Console.SetCursorPosition(i, 21);
                            Console.WriteLine(" ********** ");
                            Console.SetCursorPosition(i, 22);
                            Console.WriteLine("  ********  ");
                            Console.SetCursorPosition(i, 23);
                            Console.WriteLine("   ******   ");
                            Console.SetCursorPosition(i, 24);
                            Console.WriteLine("    ****    ");
                            Console.SetCursorPosition(i, 25);
                            Console.WriteLine("     **     ");

                            Console.SetCursorPosition((73 - i), 18);
                            Console.WriteLine("  **    **  ");
                            Console.SetCursorPosition((73 - i), 19);
                            Console.WriteLine(" ****  **** ");
                            Console.SetCursorPosition((73 - i), 20);
                            Console.WriteLine("************");
                            Console.SetCursorPosition((73 - i), 21);
                            Console.WriteLine(" ********** ");
                            Console.SetCursorPosition((73 - i), 22);
                            Console.WriteLine("  ********  ");
                            Console.SetCursorPosition((73 - i), 23);
                            Console.WriteLine("   ******   ");
                            Console.SetCursorPosition((73 - i), 24);
                            Console.WriteLine("    ****    ");
                            Console.SetCursorPosition((73 - i), 25);
                            Console.WriteLine("     **     ");

                            Thread.Sleep(60);
                            Console.Clear();

                        }
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        SystemSounds.Exclamation.Play();

                        for (int i = 18; i > 8; i--)
                        {
                            Console.SetCursorPosition(30, (i));
                            Console.WriteLine("  **    **  ");
                            Console.SetCursorPosition(30, (i + 1));
                            Console.WriteLine(" ****  **** ");
                            Console.SetCursorPosition(30, (i + 2));
                            Console.WriteLine("************");
                            Console.SetCursorPosition(30, (i + 3));
                            Console.WriteLine(" ********** ");
                            Console.SetCursorPosition(30, (i + 4));
                            Console.WriteLine("  ********  ");
                            Console.SetCursorPosition(30, (i + 5));
                            Console.WriteLine("   ******   ");
                            Console.SetCursorPosition(30, (i + 6));
                            Console.WriteLine("    ****    ");
                            Console.SetCursorPosition(30, (i + 7));
                            Console.WriteLine("     **     ");

                            Console.SetCursorPosition(43, (i));
                            Console.WriteLine("  **    **  ");
                            Console.SetCursorPosition(43, (i + 1));
                            Console.WriteLine(" ****  **** ");
                            Console.SetCursorPosition(43, (i + 2));
                            Console.WriteLine("************");
                            Console.SetCursorPosition(43, (i + 3));
                            Console.WriteLine(" ********** ");
                            Console.SetCursorPosition(43, (i + 4));
                            Console.WriteLine("  ********  ");
                            Console.SetCursorPosition(43, (i + 5));
                            Console.WriteLine("   ******   ");
                            Console.SetCursorPosition(43, (i + 6));
                            Console.WriteLine("    ****    ");
                            Console.SetCursorPosition(43, (i + 7));
                            Console.WriteLine("     **     ");

                            if (i == 18)
                                Thread.Sleep(1000);
                            else
                                Thread.Sleep(60);

                            if (i != 9)
                                Console.Clear();
                        }

                        movement++;
                        break;

                }   //close switch



            }   //close while

            Thread.Sleep(800);

            //print to console for introduction
            Console.WriteLine(@" _____   _              ___           _     _                     _                 ");
            Console.WriteLine(@"|_   _| | |_    ___    |   \   __ _  | |_  (_)  _ _    __ _      /_\    _ __   _ __ ");
            Console.WriteLine(@"  | |   | ' \  / -_)   | |) | / _` | |  _| | | | ' \  / _` |    / _ \  | '_ \ | '_ \");
            Console.WriteLine(@"  |_|   |_||_| \___|   |___/  \__,_|  \__| |_| |_||_| \__, |   /_/ \_\ | .__/ | .__/");
            Console.WriteLine(@"                                                      |___/            |_|    |_|   ");
            Thread.Sleep(1600);
            Console.SetCursorPosition(21, 28);
            Console.Write(@"--/-<@  Welcome to the Dating App!  @>-\---");
            Thread.Sleep(2000);
            Console.WriteLine("\n\n\n\n\t With just a few questions you will be able to find your true love!");
            Thread.Sleep(1600);
            Console.WriteLine("\n\n\n\t\t\t Press any key to make a match.");
            Console.ReadKey(true);

        }   //close method HeartsMoving

    }
}
