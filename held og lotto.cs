using System;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 0; i < 8; i++)
            {
                Random random = new Random();//
                int lottery = random.Next(1, 7);
                Console.Write(lottery);
                
            }
            for (int i = 0; i < 1; i++)
            {
                Random random = new Random();
                int lottery = random.Next(0, 3);
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(lottery);
            }
            Console.ReadLine();

            
        }
    }
}
