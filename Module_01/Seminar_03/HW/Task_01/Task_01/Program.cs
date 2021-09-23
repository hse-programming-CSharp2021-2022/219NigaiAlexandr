using System;

namespace Task_01
{
    class Program
    {
        static bool G(double x, double y)
        {
            if (x >= 0 && y <= x && x * x + y * y <= 4)
                return true;

            return false;
        }

        public static void Main (string[] args)
        {
            Console.WriteLine(G(0, .1));
        } 
    }
}