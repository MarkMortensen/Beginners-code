using System;

namespace Nimgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Der er tolv tændstikker.\n" + //The console says there are twelve matches.
                   "Du kan tag 1, 2, eller 3 når det er din tur.\n" + //The console says you can pick 1, 2 or 3 when its your turn
                   "Den der tager den sidste tændstik vinder.\n"); 

            int tokens = 7;// int tokens = 7 because there are 7 macthes in total.

            while (tokens > 0) // while tokens are bigger than 0 it will loop through this code.
            {
                Console.WriteLine("Der er " + tokens + " tilbage.");
                Console.WriteLine("Hvor mange tager du?");
                int playertake = Convert.ToInt32(Console.ReadLine());// converts users answer from string to int.

                if (playertake < 1 || playertake > 3)// if the user takes more than 4 or less than 1 it will execute the code below.
                {
                    Console.WriteLine("1, 2, or 3 only.");
                }
                else
                {
                    
                }
            }
            Console.WriteLine("Jeg vandt igen.");// when there are zero matches left it will print this code in console
            Console.ReadLine();
        }
    }
}
