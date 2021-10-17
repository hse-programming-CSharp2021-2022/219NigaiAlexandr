using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task_01
{
    class Program
    {
        static void Print<T>(IEnumerable<T> request)
        {
            foreach (var i in request)
                Console.Write($"{i} ");

            Console.WriteLine();
        }

        static void Main()
        {
            var rand = new Random(0);
            int n = int.Parse(Console.ReadLine());

            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(rand.Next(1, 10001));
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();
            
            var request1 = list.Where(x => x.ToString().Length == 2 && x % 3 == 0);
            Print(request1);

            var request2 = list.Where(x =>
            {
                string s = x.ToString();
                for (int i = 0; i < s.Length/2; i++)
                {
                    if (s[i] != s[s.Length - i - 1])
                        return false;
                }
                return true;
            });
            Print(request2);

            var request3 = list.OrderBy(x =>
            {
                int sum = 0;
                int t = x;
                while (t > 0)
                {
                    sum += t % 10;
                    t /= 10;
                }
                return sum;
            }).ThenBy(x => x);

            Print(request3);

            var request4 = list.Where(x => x.ToString().Length == 4).DefaultIfEmpty().Sum();

            Console.WriteLine(request4);

            var request5 = list.Where(x => x.ToString().Length == 2).DefaultIfEmpty().Min();

            Console.WriteLine(request5);

            var request6 = list.Select(x =>
            {
                var digits = new List<int>();
                for (int i = 0; i < x.ToString().Length; i++)
                {
                    digits.Add(Convert.ToInt32(x.ToString()[i]) - 48);
                }
                return digits.Max();
            });

            Print(request6);
        }
    }
}
