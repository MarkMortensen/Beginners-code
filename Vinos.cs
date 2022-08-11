using System;

namespace vinesales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vinesales = new int[11];

            vinesales[0] = 175134;
            vinesales[1] = 175388;
            vinesales[2] = 172818;
            vinesales[3] = 142709;
            vinesales[4] = 151437;
            vinesales[5] = 152620;
            vinesales[6] = 150979;
            vinesales[7] = 152210;
            vinesales[8] = 149450;
            vinesales[9] = 154398;
            vinesales[10] = 154398;

            for(int i = 0; i < vinesales.Length; i++)
            {
                Console.WriteLine(vinesales[i]);
            }

            const int max = 175388;
            int[] year = { 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019 };
            for(int i = 0; i < year.Length; i++)
            {
                Console.WriteLine(year[i]);

                int stars = vinesales[i] * 100 / max;
                for(int d = 0; d < stars; d++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }





        }
    }
}
