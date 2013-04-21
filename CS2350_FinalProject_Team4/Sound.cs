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

        public static void introMusic()
        {
            new System.Media.SoundPlayer(Properties.Resources.Let_s_Get_It_On_CS).Play();
        }

        public static void soSorryMusic()
        {
            new System.Media.SoundPlayer(Properties.Resources.All_By_Myself_CS).Play();
        }

    }
}
