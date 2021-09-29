using System;

namespace Task_02
{
    class Program
    {
        static void Y(double a, double b, double c)
        {
            for (double x = 1; x <= 2; x += .05)
            {
                if (x < 1.2)
                    Console.WriteLine($"x = {x} y = {a * x * x + b * x + c}");
                else if (x == 1.2)
                    Console.WriteLine($"x = {x} y = {a / x + Math.Sqrt(x * x + 1)}");
                else 
                    Console.WriteLine($"x = {x} y = {(a + b * x)/Math.Sqrt(x * x + 1)}");
            }
        }
        
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Y(a, b, c);
        }
    }
}