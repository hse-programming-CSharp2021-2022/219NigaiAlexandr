using System;

namespace Task_03
{
    class Program
    {

        static bool Triangle(double x, double y, double z, out double p, out double s)
        {
            if (x + y < z || y + z < x || z + x < y)
            {
                s = 0;
                p = 0;
                return false;
            }
            p = x + y + z;
            s = Math.Sqrt((p / 2) * (p / 2 - x) * (p / 2 - y) * (p / 2 - z));
            return true;
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введи сторону x: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введи сторону y: ");
                double y = double.Parse(Console.ReadLine());
                Console.Write("Введи сторону z: ");
                double z = double.Parse(Console.ReadLine());

                Triangle(x, y, z, out double p, out double s);
                Console.WriteLine($"Периметр: {p}\nПлощадь: {s}");
            }
        }
    }
}