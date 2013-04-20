using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace CS2350_FinalProject_Team4
{
    class Compatability
    {

        ArrayList compareClient;

        public Compatability(ArrayList aClient)
        {
            compareClient = aClient;
            Display(compareClient);

        }



        //testing correct passing of info
        public static void Display(ArrayList anArrayList)
        {
            foreach (var i in anArrayList)
            {
                int p = 0;
                Console.WriteLine("The value at the arrayList index " + p +" is:  " + i);
                p++;
            }

            Console.ReadKey(true);
        }


    }
}
