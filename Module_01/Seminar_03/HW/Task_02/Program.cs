using System;

namespace Task_02
{
    class Program
    {
        static double G(double x, double y)
        {
            if (x > 0 && x < y) return x + Math.Sin(y);
            if (x > y && x < 0) return y - Math.Cos(x); 
            return 0.5 * x * y;
        }

        public static void Main (string[] args)
        {
            Console.WriteLine(G(0, .1));
        } 
    }
}