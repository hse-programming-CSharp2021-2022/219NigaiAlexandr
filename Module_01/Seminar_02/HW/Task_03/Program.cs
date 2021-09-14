using System;

namespace Task_03
{
    class Program
    {

        static void SolveEquation(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            string ans = (d >= 0 & !(b == 0 & c == 0)) ? (d == 0) ? $"X = {-b / (2 * a)}" :
                $"X1 = {((-b + Math.Sqrt(d)) / (2 * a))}\nX2 = {((-b - Math.Sqrt(d)) / (2 * a))}" : 
                "Нет решений";

            Console.WriteLine(ans);
        }

        static void Main(string[] args)
        {
            do
            {
                string abc = "ABC";
                double[] coefs = new double[3];
                for (int i = 0; i < 3; i++)
                {
                    string inp;
                    do
                    {
                        Console.Write($"Введите значение {abc[i]}: ");
                        inp = Console.ReadLine();
                    } while (!double.TryParse(inp, out coefs[i]));
                }

                SolveEquation(coefs[0], coefs[1], coefs[2]);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
