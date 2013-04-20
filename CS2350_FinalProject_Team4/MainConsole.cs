using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace CS2350_FinalProject_Team4
{
    class MainConsole
    {

        static void Main(string[] args)
        {
            //create graphics object to pass to graphics class for any visuals
            Graphics graphObj = new Graphics();

            //set console size and basic attributes
            Graphics.ConsoleBasics();
            Graphics.ConsoleIntro();

            //send to opening sequence animation
 //           Graphics.HeartsMoving();


            //call client object
            Client currentClient = new Client();


            //send client object to compatability class
            Compatability compare = new Compatability(currentClient.CurrentClient);

            
            

        }   //close main

    }
}
