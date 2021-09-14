using System;
using System.Globalization;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string inp;
                double b;
                do
                {
                    Console.Write("Введите бюджет: ");
                    inp = Console.ReadLine();
                } while (!double.TryParse(inp, out b));

                int p;
                do
                {
                    Console.Write("Введите процент: ");
                    inp = Console.ReadLine();
                } while (!(int.TryParse(inp, out p) && p <= 100 && p >= 0));

                Console.WriteLine($"Бюджет на игры: {(b / 100 * p).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
