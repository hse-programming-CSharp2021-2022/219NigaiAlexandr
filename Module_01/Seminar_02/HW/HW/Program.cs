using System;

namespace HW
{
    class Program
    {
        static double F(double x)
        {
            return (12 * x * x * x * x + 9 * x * x * x - 3 * x * x + 2 * x - 4);
        }

        static void Main(string[] args)
        {
            do
            {
                string inp;
                double x;
                do
                {
                    Console.Write("Введите значение x: ");
                    inp = Console.ReadLine();
                } while (!double.TryParse(inp, out x));

                Console.WriteLine($"F(x) = {F(x)}");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
