using System;

namespace Amerikansk_flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast din fødselsdato");
            int år = Convert.ToInt32(Console.ReadLine());

            int fødsels = (2022 - år);
            
            Console.WriteLine("Du er " + fødsels + " år gammel");
          
        }
    }
}
