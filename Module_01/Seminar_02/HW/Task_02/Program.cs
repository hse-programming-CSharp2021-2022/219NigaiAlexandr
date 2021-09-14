using System;

namespace Task_02
{
    class Program
    {

        static string MaxPossibleNumber(string n)
        {
            string ans = "";
            int max = 0;

            for (int i = 0; i < 2; i++)
            {
                max = 0;
                foreach (var number in n)
                {
                    if (int.Parse(number.ToString()) > max) max = int.Parse(number.ToString());
                }
                ans += max.ToString();
                n = n.Remove(n.IndexOf(max.ToString()));
            }
            ans += n;
            return ans;
        }

        static void Main(string[] args)
        {

            do
            {
                int n;
                string inp;
                do
                {
                    Console.Write("Введите трехзначное число: ");
                    inp = Console.ReadLine();
                } while (inp.Length != 3 || !int.TryParse(inp, out n));

                Console.WriteLine($"Наибольшее число, полученное перестановками: {MaxPossibleNumber(inp)}");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
