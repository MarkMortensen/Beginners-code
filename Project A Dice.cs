using System;

namespace Project_B_Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dice = random.Next(1, 7);

            if (dice == 1) // if the number the dice generates is one, the backgroundcolor is gonna be set to red and it will print the text below it.
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Du slog en etter"); 
            }
            else if (dice == 2)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Du slog en to'er");

            }
            else if (dice == 3)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Du slog en tre'er");
            }
            else if (dice == 4)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Du slog en fire");
            }
            else if (dice == 5)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Du slog en femmer");
            }
            else // if none of the statements above is true the code below is gonna be executet with the text color as yellow.
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jubii du slog en sekser");
            }
            Console.ReadLine();
        }
    }
}
