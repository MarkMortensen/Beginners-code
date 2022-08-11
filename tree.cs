using System;

namespace tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int spaces = 10;// spaces is set to 10.
            int stars = 1;// int stars is set to 1
            for (int i = 0; i < 10; i++)//forloop int i is set to 0,while 10 is bigger than i loop through this loop and i++ adds 1 every time it loops
            {
                for (int j = 0; j < spaces; j++)// forloop j is also set to 0, while spaces is bigger than j it will loop through this loop and adds one every time until j is equal to spaces or bigger.
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < stars; j++) //forloop int j is set to 0, while stars are bigger than j it will run through the loop until j is either equal to stars or bigger.
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                spaces--;
                stars++;

            }
        }
    }
}
