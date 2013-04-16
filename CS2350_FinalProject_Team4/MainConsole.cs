using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CS2350_FinalProject_Team4
{
    class MainConsole
    {
        static void Main(string[] args)
        {

            //alter console graphics and measurements
          Console.Title = "Richard_Bradley_CS2350_Lab_7 Assignment 7";
            Console.SetWindowSize(85, 43);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            Console.Clear();
            /* 
                       Sound.RangedBeep();
                       Sound.SystemSound();

                       Console.Write("Loading");
                       for (int i = 0; i < 10; i++)
                       {
                           Thread.Sleep(100);
                           Console.Write(".");
                       }
             */

            ConsoleSpinner spin = new ConsoleSpinner();
            Console.Write("Working....");
            while (true)
            {
                spin.Turn();
            }
        }

    }
}
