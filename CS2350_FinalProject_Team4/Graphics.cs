using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace CS2350_FinalProject_Team4
{
    class Graphics
    {
        //random objest for response randomizer
        private static Random randomBust = new Random();

        //Thread Sleep() will be used to slow console write speed for a better user experience


        public Graphics()
        {
        }

        //center console to screen
        public static void CenterConsole()
        {
            IntPtr hWin = GetConsoleWindow();
            RECT rc;
            GetWindowRect(hWin, out rc);
            Screen scr = Screen.FromPoint(new Point(rc.left, rc.top));
            int x = scr.WorkingArea.Left + (scr.WorkingArea.Width - (rc.right - rc.left)) / 2;
            int y = scr.WorkingArea.Top + (scr.WorkingArea.Height - (rc.bottom - rc.top)) / 2;
            MoveWindow(hWin, x, y, rc.right - rc.left, rc.bottom - rc.top, false);
        }

        // P/Invoke declarations
        private struct RECT { public int left, top, right, bottom; }
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT rc);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hWnd, int x, int y, int w, int h, bool repaint);


        //set general size, no visible cursor
        public static void ConsoleBasics()
        {
            //alter console graphics and measurements
            Console.Title = "CS2350 Final Project - Group 4";
            Console.SetWindowSize(85, 43);
            Console.CursorVisible = false;
            Console.Clear();
        }

        //screen look for initial view
        public static void TeamSplash()
        {
            //opening sequece colors
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
        }


        //main intro sequence with animation
        public static void ConsoleIntro()
        {
            //opening sequece colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        //screen after intro sequence
        public static void GenderConsole()
        {
            Console.Clear();
            Console.SetCursorPosition(21, 12);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(@"--/-<@  Welcome to the Dating App!  @>-\---");
            Console.SetCursorPosition(21, 22);
        }

        //set background and text color for male user
        public static void MaleConsole()
        {

            Console.Title = @"--/-<@  The Dating App!  @>-\---";
            //gender sequece colors
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(21, 22);

        }

        //set background and text color for female user
        public static void FemaleConsole()
        {

            Console.Title = @"--/-<@  The Dating App!  @>-\---";
            //gender sequece colors
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetCursorPosition(21, 22);
        }

        //no match screen background
        public static void SoSorryConsole()
        {

            Console.Title = @"--/-<@  Better luck next time!  @>-\---";
            //gender sequece colors
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

        }

        //age under 16 result screen
        public static void TooYoungFont()
        {

            Console.Clear();
            Thread.Sleep(1000);
            Console.SetCursorPosition(2, 10);
            Console.Write("ARE YOU CRAZY!?!  LIKE WE'RE GOING TO CONTRIBUTE TO THE DELINQUENCY OF A MINOR...");
            Thread.Sleep(3000);
            Console.SetCursorPosition(21, 18);
            Console.Write("Since we wouldn't dream of that and you seem nice....");
            Thread.Sleep(2000);
            Console.SetCursorPosition(21, 22);
            Console.Write("Let's just assume that was a typo and you try that again.");
            Thread.Sleep(2500);
            Console.SetCursorPosition(21, 26);
            Console.Write("Take a moment to ponder the legal age of consent......");
            Thread.Sleep(3500);
            Console.Clear();

        }

        //final screen after positive match
        public static void FinalScreen()
        {
            Console.Clear();
            Thread.Sleep(1000);
            Console.SetCursorPosition(2, 10);
            Console.Write("We wish you the best of luck in your happy union!");
            Thread.Sleep(3000);
            Console.SetCursorPosition(14, 18);
            Console.Write("We feel confident that this is the match for you.");
            Thread.Sleep(2000);
            Console.SetCursorPosition(14, 22);
            Console.Write("After all, we used the latest in scientific matching tools...");
            Thread.Sleep(2500);

            //randomizer for occasional no match scene
            int difResponse = Convert.ToInt32(randomBust.Next(4));
            string display;


            switch (difResponse)  //vary output message
            {
                case 1:
                    display = "We made sure the coin had two different heads!";
                    break;
                case 2:
                    display = "Tea leaves are a tried and true divination method....";
                    break;
                case 3:
                    display = "Our giant spinning wheel of fortune never lies!";
                    break;
                default:
                    display = "The ancient prophecies fortold your coming, AND your ideal date!\n  They're nice that way..";
                    break;
            }


            Console.SetCursorPosition(2, 26);
            Console.Write(display);
            Thread.Sleep(3500);
            Console.Clear();

            Console.SetCursorPosition(21, 26);
            Console.Write("Press any key to begin your new Happy Existence!");
            Console.ReadKey(true);
        }


        //the following are ascii art fonts for screen headers and graphics

        public static void MatchFont()
        {

            Console.Clear();
            Console.WriteLine(@"         _  _              _  _              _  _              _  _            ");
            Console.WriteLine(@"       /` \/ `\   _  _   /` \/ `\   _  _   /` \/ `\   _  _   /` \/ `\   _  _   ");
            Console.WriteLine(@"       \      / /` \/ `\ \      / /` \/ `\ \      / /` \/ `\ \      / /` \/ `\ ");
            Console.WriteLine(@"        '.  .'  \      /  '.  .'  \      /  '.  .'  \      /  '.  .'  \      / ");
            Console.WriteLine(@"          \/     '.  .'     \/     '.  .'     \/     '.  .'     \/     '.  .'  ");
            Console.WriteLine(@"                   \/                \/                \/                \/    ");

            Thread.Sleep(1500);

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

        //graphics for intro screen
        public static void TeamFont()
        {
            Thread.Sleep(2000);
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine(@"           ______                                ____                        ");
            Console.WriteLine(@"          /\__  _\                              /\  _\                      ");
            Console.WriteLine(@"          \/_/\ \/    __     __      ___ ___    \ \ \L   ___   __  __  _ __  ");
            Console.WriteLine(@"             \ \ \  /'__`\ /'__`\  /' __` __`\   \ \  _\/ __`\/\ \/\ \/\`'__\");
            Console.WriteLine(@"              \ \ \/\  __//\ \L\.\_/\ \/\ \/\ \   \ \ \/\ \L\ \ \ \_\ \ \ \/ ");
            Console.WriteLine(@"               \ \_\ \____\ \__/.\_\ \_\ \_\ \_\   \ \_\ \____/\ \____/\ \_\ ");
            Console.WriteLine(@"                \/_/\/____/\/__/\/_/\/_/\/_/\/_/    \/_/\/___/  \/___/  \/_/ ");
            Thread.Sleep(2000);
            Console.WriteLine("\n\n\n\n\t\t  [ Chuda Curtis, Stanley Muthoga, Rick Bradley ]\n\n\n\n\n\n");
            Thread.Sleep(2000);
            Console.WriteLine(@"                                                      .                    ");
            Console.WriteLine(@"                                                     _|_                   ");
            Console.WriteLine(@"              ____  ____   .,-. .--..-. .--. .-. .--. |  .--.   ____  ____ ");
            Console.WriteLine(@"                           |   )|  (.-' `--.(.-' |  | |  `--.              ");
            Console.WriteLine(@"                           |`-' '   `--'`--' `--''  `-`-'`--'              ");
            Console.WriteLine(@"                           |                                               ");
            Console.WriteLine(@"                           '                                               ");
            Thread.Sleep(3000);

        }

        public static void SoSorryFont()
        {
            Sound.SoSorryMusic();
            Console.WriteLine(@"                  |                   ");
            Console.WriteLine(@"                  |                   ");
            Console.WriteLine(@"                 :::,_____            ");
            Console.WriteLine(@"               ::::/./^^^^\           ");
            Console.WriteLine(@"            :::::::|| ^ ^ |           ");
            Console.WriteLine(@"          ::::::::(s u , u')          ");
            Console.WriteLine(@"            :::::''\\__^__/           ");
            Console.WriteLine(@"             :::::/ ｌ __l\           ");
            Console.WriteLine(@"            :::::|-|/    <-\          ");
            Console.WriteLine(@"             :::::＼{(_) {( ) ＿＿＿＿ ");
            Console.WriteLine(@"             :::::|-|_|:|_|           ");
            Console.WriteLine(@"               /｀-  ( ) ( )          ");
            Console.WriteLine(@"              /                       ");
            Console.WriteLine(@"             /                        ");

            Console.SetCursorPosition(21, 22);
            Thread.Sleep(2000);
            Console.WriteLine("You know, sometimes.......");
            Thread.Sleep(2000);

            Console.SetCursorPosition(21, 25);
            Console.Write("these ");
            Thread.Sleep(400);
            Console.Write("things ");
            Thread.Sleep(400);
            Console.Write("just ");
            Thread.Sleep(400);
            Console.Write("don't ");
            Thread.Sleep(200);
            Console.Write("work ");
            Thread.Sleep(200);
            Console.Write("out ");
            Thread.Sleep(200);
            Console.Write("..... ");
            Thread.Sleep(4000);



            Console.SetCursorPosition(30, 29);
            Console.WriteLine("We recommend:");
            Thread.Sleep(2000);
            //change console look for next screen
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine(@"            _,'|             _.-''``-...___..--';)  ");
            Console.WriteLine(@"           /_ \'.      __..-' ,      ,--...--'''      ___   __  ____  ____ ");
            Console.WriteLine(@"          <\    .`--'''       `     /'               / __) / _\(_  _)/ ___)");
            Console.WriteLine(@"           `-';'               ;   ; ;              ( (__ /    \ )(  \___ \");
            Console.WriteLine(@"     __...--''     ___...--_..'  .;.'                \___)\_/\_/(__) (____/");
            Console.WriteLine(@"    (,__....----'''       (,..--''                  ");

            Thread.Sleep(2000);
            Console.SetCursorPosition(30, 29);
            Console.Write("Lots ");
            Thread.Sleep(400);
            Console.Write("and LOTS ");
            Thread.Sleep(400);
            Console.Write("of cats....");
            Thread.Sleep(4000);

            Console.SetCursorPosition(25, 32);
            Console.WriteLine("Press any key to resume the rest of your life....");
            Console.ReadKey(true);

            //stop program here
            Environment.Exit(0);
        }

        //animated hearts moving accross screen and meeting
        public static void HeartsMoving()
        {
            int movement = 1;
            Console.Clear();
            Thread.Sleep(1000);
            while (movement < 3)
            {
                switch (movement)
                {
                    case 1: //moving across top and bottom
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
                    case 2: //moving towards each other in center
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

                        for (int i = 18; i > 8; i--)    //moving up from center
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
