using System;

namespace Morsekode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//takes users input and stores it
            
            for (int i = 0; i < input.Length; i++) //int i is set to 0 and input.length is set to be bigger than i and then i++ adds 1 until we tells it to stop.

            switch (i)
            {
                case 'a':
                    Console.WriteLine(".- ");
                    break;
                case 'b':
                    Console.WriteLine("-...");
                    break;
                case 'c':
                    Console.WriteLine("-.-.");
                    break;
                case 'd':
                    Console.WriteLine("-..");
                    break;
                case 'e':
                    Console.WriteLine(".");
                    break;
                case 'f':
                    Console.WriteLine("..-.");
                    break;
                case 'g':
                    Console.WriteLine("--.");
                    break;
                case 'h':
                    Console.WriteLine("....");
                    break;
                case 'i':
                    Console.WriteLine("..");
                    break;
                case 'j':
                    Console.WriteLine("· — — —");
                    break;
                case 'k':
                    Console.WriteLine("— · —");
                    break;
                case 'l':
                    Console.WriteLine("· — · ·");
                    break;
                case 'n':
                    Console.WriteLine("— ·");
                    break;
                case 'm':
                    Console.WriteLine("— —");
                    break;
                case 'o':
                    Console.WriteLine("— — —");
                    break;
                case 'p':
                    Console.WriteLine("· — — · ");
                    break;
                case 'q':
                    Console.WriteLine("— — · — ");
                    break;
                case 'r':
                    Console.WriteLine("· — · ");
                    break;
                case 's':
                    Console.WriteLine("· · ·");
                    break;
                case 't':
                    Console.WriteLine("—");
                    break;
                case 'u':
                    Console.WriteLine("· · —");
                    break;
                case 'v':
                    Console.WriteLine("· · · — ");
                    break;
                case 'w':
                    Console.WriteLine("· ——");
                    break;
                case 'x':
                    Console.WriteLine("— · · —");
                    break;
                case 'y':
                    Console.WriteLine("— · — —");
                    break;
                case 'z':
                    Console.WriteLine("— — · ·");
                    break;




            }
            











        }
    }
}
