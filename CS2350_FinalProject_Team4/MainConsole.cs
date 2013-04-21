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
            Graphics.CenterConsole();

            //create graphics object to pass to graphics class for any visuals
            Graphics graphObj = new Graphics();

            
            //set console size and basic attributes
            Graphics.ConsoleBasics();
            Graphics.TeamSplash();
            

            //call intro music
            Sound.introMusic();

            //call text for initial splash page
            Graphics.TeamFont();



            //send to opening sequence animation
            Graphics.ConsoleIntro();
            Graphics.HeartsMoving();    


            //call client object
            Client currentClient = new Client();


            //send client object to compatability class
            Compatability compare = new Compatability(currentClient.CurrentClient);

            Console.ReadKey(true);

            Graphics.SoSorryConsole();
            Graphics.SoSorryFont();

            
            

        }   //close main

    }
}
