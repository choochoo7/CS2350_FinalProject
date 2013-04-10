using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace CS2350_FinalProject_Team4
{
    class Sound
    {
        public static void RangedBeep()
        {
            for (int i = 37; i <= 2767; i += 200)
            {
                Console.Beep(i, 100);
            }
        }

        public static void SystemSound()
        {
            Console.WriteLine("Asterisk");
            SystemSounds.Asterisk.Play();
            Thread.Sleep(1000);

            Console.WriteLine("Beep");
            SystemSounds.Beep.Play();
            Thread.Sleep(1000);

            Console.WriteLine("Exclamation");
            SystemSounds.Exclamation.Play();
            Thread.Sleep(1000);

            Console.WriteLine("Hand");
            SystemSounds.Hand.Play();
            Thread.Sleep(1000);

            Console.WriteLine("Question");
            SystemSounds.Question.Play();
            Thread.Sleep(1000);
        }

        //comments to force save to check on GitHub response


    }
}
