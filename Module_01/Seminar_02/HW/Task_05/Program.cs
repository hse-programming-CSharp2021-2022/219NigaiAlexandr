using System;

namespace Task_05
{
    class Program
    {

        static string Check(double a, double b, double c)
        {
            string ans;

            bool flag;
            flag = (a + b >= c) ? true : false;
            flag = (a + c >= b) ? true : false;
            flag = (c + b >= a) ? true : false;
            if (flag)
                return "Такой треугольник возможен";
            else
                return "Так треугольник невозможен";
        }

        static void Main(string[] args)
        {
            do
            {
                string abc = "abc";
                double[] coefs = new double[3];
                for (int i = 0; i < 3; i++)
                {
                    string inp;
                    do
                    {
                        Console.Write($"Введите длину стороны {abc[i]}: ");
                        inp = Console.ReadLine();
                    } while (!double.TryParse(inp, out coefs[i]));
                }

                Console.WriteLine(Check(coefs[0], coefs[1], coefs[2]));
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
