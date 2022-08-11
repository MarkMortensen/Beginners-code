using System;

namespace Tempareturberegner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast nummeret af celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("reamur = {0}", celsius * 0.8);
            Console.WriteLine("Fahrenheit = {0}", celsius * 1.8 + 32);

            Console.ReadLine();
          



        }
    }
}
