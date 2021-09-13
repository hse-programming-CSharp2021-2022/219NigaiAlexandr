using System;

namespace Task05 //Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите величину первого катета: ");
            string x = Console.ReadLine();
            Console.Write("Введите величину второго катета: ");
            string y = Console.ReadLine();
            double u, r;
            if (!double.TryParse(x, out u) || !double.TryParse(y, out r))
                Console.WriteLine("Некорректный ввод");
            else
            {
                Console.WriteLine($"Гипотенуза: {Math.Sqrt(u * u + r * r)}");
            }
        }
    }
}