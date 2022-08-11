using System;

namespace Rumfanget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indtast længden på rumfanget");
            double længde =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast bredden på rumfanget");
            double bredden = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast højden på rumfanget");
            double højden = Convert.ToDouble(Console.ReadLine());

            double total = bredden * længde * højden;
            Console.WriteLine("resultatet er " + total);
            Console.ReadLine();


        }
    }
}
