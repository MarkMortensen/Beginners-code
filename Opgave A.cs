using System;

namespace Opgave_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 16;
            double width = 5.1;
            Console.WriteLine(length * width);

            int area = width * length;//Den kan ikke convertere int til double da int kun kan tage heltal.

            double d = width * length; //En double kan godt tag heltal men int kan ikke tage commatal.
        }
    }
}