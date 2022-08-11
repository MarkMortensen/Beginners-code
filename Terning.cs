using System;

namespace Terning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dice = random.Next(1, 7);//It generates a random number between 1 and 6.

            if (dice == 1) // if the random generator is one, it prints out the text below in console.
            {
                Console.WriteLine("Du slog en etter");
            }
            else if (dice == 2)
            {
                Console.WriteLine("Du slog en to'er");
            }
            else if (dice == 3)
            {
                Console.WriteLine("Du slog en tre'er");

            }
            else if (dice == 4)
            {
                Console.WriteLine("Du slog en fire");
            }
            else if (dice == 5)
            {
                Console.WriteLine("Du slog en femmer");
            }
            else
            {
                Console.WriteLine("Jubii du slog en sekser!");//if nothing above is true it executes this line of code.
            }
            Console.ReadLine();//keeps the console open till the user presses enter.
        }
    }
}
