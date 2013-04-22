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

        public static void IntroMusic()
        {
            new System.Media.SoundPlayer(Properties.Resources.Let_s_Get_It_On_CS).Play();
        }

        public static void SoSorryMusic()
        {
            new System.Media.SoundPlayer(Properties.Resources.All_By_Myself_CS).Play();
        }

        public static void DrumRollMusic()
        {
            new System.Media.SoundPlayer(Properties.Resources.Drums_cs).Play();
        }

        public static void MatchMusic()
        {
            new System.Media.SoundPlayer(Properties.Resources.Cant_Get_Enough_CS).Play();
        }

    }
}
