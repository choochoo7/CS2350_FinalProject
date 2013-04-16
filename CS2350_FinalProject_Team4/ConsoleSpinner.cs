using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace CS2350_FinalProject_Team4
{
    class ConsoleSpinner
    {
    int counter;
    public ConsoleSpinner()
    {
        counter = 0;
    }
    public void Turn()
    {
        counter++;        
        switch (counter % 2)
        {
            case 0:
                Console.WriteLine("  **    **  ");
                Console.WriteLine(" ****  **** ");
                Console.WriteLine("************");
                Console.WriteLine(" ********** ");
                Console.WriteLine("  ********  ");
                Console.WriteLine("   ******   ");
                Console.WriteLine("    ****    ");
                Console.WriteLine("     **     ");
                break;
            case 1: 
                Console.WriteLine("  !!    !!  ");
                Console.WriteLine(" !!!!  !!!! ");
                Console.WriteLine("!!!!!!!!!!!!");
                Console.WriteLine(" !!!!!!!!!! ");
                Console.WriteLine("  !!!!!!!!  ");
                Console.WriteLine("   !!!!!!   ");
                Console.WriteLine("    !!!!    ");
                Console.WriteLine("     !!     ");
                break;
        }
        Thread.Sleep(100);
        Console.Clear();



    }


    }
}
/*

  **    **  
 ****  **** 
************
 ********** 
  ********  
   ******   
    ****    
     **     
*/