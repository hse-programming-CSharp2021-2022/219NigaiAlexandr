using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите U: ");
            string x = Console.ReadLine();
            Console.Write("Введите R: ");
            string y = Console.ReadLine();
            double u, r;
            if (!double.TryParse(x, out u) || !double.TryParse(y, out r))
                Console.WriteLine("Некорректный ввод");
            else
            {
                Console.WriteLine($"Сила тока: {u/r}");
                Console.WriteLine($"Потребляемая мощность: {(u * u)/r}");
            }
        }
    }
}