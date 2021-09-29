using System;

namespace Task_05
{
    class Program
    {
        static void Sum(int n)
        {
            double s = 0;
            for (int i = 1; i < n; i++)
            {
                s += (i + 0.3) / (3 * i * i + 5);
                Console.WriteLine(i + " " + s);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Sum(n);
        }
    }
}