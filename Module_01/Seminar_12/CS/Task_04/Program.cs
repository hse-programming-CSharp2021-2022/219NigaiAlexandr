using System;
using System.Text.RegularExpressions;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            var r = new Regex(@"\d+");
            int max = 0;
            foreach (var m in r.Matches(s))
            {
                if (m.ToString().Length > max)
                    max = m.ToString().Length;
            }

            Console.WriteLine(max);
        }
    }
}
