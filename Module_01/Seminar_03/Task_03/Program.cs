using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        { 
            double a = 10, delta = 0.02, k = 0, s = 0;
            while (k < a)
            {
                s += ((k * k) + (k + delta) * (k + delta)) * delta / 2;
                k += delta;
            }

            Console.WriteLine(s);
        }
    }
}