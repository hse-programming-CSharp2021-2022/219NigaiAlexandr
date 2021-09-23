using System;

namespace Task_03
{
    class Program
    {
        static double G(double x)
        {
            if (x <= .5) return 1;
            return Math.Sin((Math.PI * (x - 1) / 2));
        }

        public static void Main (string[] args)
        {
            Console.WriteLine(G(0));
        } 
    }
}