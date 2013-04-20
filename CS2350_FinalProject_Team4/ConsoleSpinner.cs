using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;


namespace CS2350_FinalProject_Team4
{
    class HeartBeat
    {
        int counter;
        public HeartBeat()
        {
            counter = 0;
        }
        public void HeartBeating()
        {
            counter++;
            switch (counter % 2)
            {
                case 0:
                    Console.SetCursorPosition(12, 12);
                    Console.WriteLine("  **    **  ");
                    Console.SetCursorPosition(12, 13);
                    Console.WriteLine(" ****  **** ");
                    Console.SetCursorPosition(12, 14);
                    Console.WriteLine("************");
                    Console.SetCursorPosition(12, 15);
                    Console.WriteLine(" ********** ");
                    Console.SetCursorPosition(12, 16);
                    Console.WriteLine("  ********  ");
                    Console.SetCursorPosition(12, 17);
                    Console.WriteLine("   ******   ");
                    Console.SetCursorPosition(12, 18);
                    Console.WriteLine("    ****    ");
                    Console.SetCursorPosition(12, 19);
                    Console.WriteLine("     **     ");
                    break;
                case 1:
                    Console.SetCursorPosition(12, 12);
                    Console.WriteLine("  !!    !!  ");
                    Console.SetCursorPosition(12, 13);
                    Console.WriteLine(" !!!!  !!!! ");
                    Console.SetCursorPosition(12, 14);
                    Console.WriteLine("!!!!!!!!!!!!");
                    Console.SetCursorPosition(12, 15);
                    Console.WriteLine(" !!!!!!!!!! ");
                    Console.SetCursorPosition(12, 16);
                    Console.WriteLine("  !!!!!!!!  ");
                    Console.SetCursorPosition(12, 17);
                    Console.WriteLine("   !!!!!!   ");
                    Console.SetCursorPosition(12, 18);
                    Console.WriteLine("    !!!!    ");
                    Console.SetCursorPosition(12, 19);
                    Console.WriteLine("     !!     ");
                    break;
            }
            Thread.Sleep(200);
            Console.Clear();



        }

        public void HeartsMoving()
        {
            int movement = 1;
            while (movement < 3)
            {
                switch (movement)
                {
                    case 1:
                        for (int i = 1; i < 73; i++)
                        {
                            Console.SetCursorPosition(i, 1);
                            Console.WriteLine("  **    **  ");
                            Console.SetCursorPosition(i, 2);
                            Console.WriteLine(" ****  **** ");
                            Console.SetCursorPosition(i, 3);
                            Console.WriteLine("************");
                            Console.SetCursorPosition(i, 4);
                            Console.WriteLine(" ********** ");
                            Console.SetCursorPosition(i, 5);
                            Console.WriteLine("  ********  ");
                            Console.SetCursorPosition(i, 6);
                            Console.WriteLine("   ******   ");
                            Console.SetCursorPosition(i, 7);
                            Console.WriteLine("    ****    ");
                            Console.SetCursorPosition(i, 8);
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
                            Thread.Sleep(80);
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

                            Thread.Sleep(80);
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
                                    Thread.Sleep(80);

                                if (i!=9)
                                    Console.Clear();
                            }


                            movement++;
                            break;

                }   //close switch



            }   //close while

        }   //close method HeartsMoving


    }
}
