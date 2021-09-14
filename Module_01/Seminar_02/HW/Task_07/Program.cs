using System;

namespace Task_07
{
    class Program
    {

        static void Fraction(double n)
        {
            Console.WriteLine($"Целая часть: {(int)n}");
            Console.WriteLine($"Дробная часть: {n - (int)n:F3}");
        }

        static void RootAndSquare(double n)
        {
            if (n >= 0) Console.WriteLine($"Корень числа: {Math.Sqrt(n)}");
            Console.WriteLine($"Квадрат числа: {n * n}");
        }

        static void Main(string[] args)
        {
            do
            {
                string inp;
                double x;
                do
                {
                    Console.Write("Введите число: ");
                    inp = Console.ReadLine();
                } while (!double.TryParse(inp, out x));

                RootAndSquare(x);
                Fraction(x);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
