using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using CS2350_FinalProject_Team4.Properties;
using WMPLib;

namespace CS2350_FinalProject_Team4
{
    class MainConsole
    {

        static void Main(string[] args)
        {
            //create graphics object to pass to graphics class for any visuals
            Graphics graphObj = new Graphics();

            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = @"C:\Users\RickB\Documents\Kennesaw\CS2350 Obj Orient Prog\CS2350_FinalProject_Team4\CS2350_FinalProject_Team4\Resources\(Disc 2) 03 - Let's Get It On (2003 Remaster Album Version).wav";
            wplayer.controls.play();



            //set console size and basic attributes
            Graphics.ConsoleBasics();
            Graphics.ConsoleIntro();

            //send to opening sequence animation
            Graphics.HeartsMoving();


            //call client object
            Client currentClient = new Client();


            //send client object to compatability class
            Compatability compare = new Compatability(currentClient.CurrentClient);

            
            

        }   //close main

    }
}
