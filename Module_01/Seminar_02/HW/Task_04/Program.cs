using System;

namespace Task_04
{
    class Program
    {

        static string Reverse(string s)
        {
            string ans = "";
            for (int i = 3; i >= 0; i--)
            {
                ans += s[i];
            }
            return ans;
        }

        static void Main(string[] args)
        {

            do
            {
                string inp = "";
                do
                {
                    Console.Write("Введите четырехзначное число: ");
                    inp = Console.ReadLine();
                } while (inp.Length != 4 || !int.TryParse(inp, out _));

                Console.WriteLine($"Число наоборот: {Reverse(inp)}");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
