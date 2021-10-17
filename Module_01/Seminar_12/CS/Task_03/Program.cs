using System;
using System.Text.RegularExpressions;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var r = new Regex(@"\b\w*a\b");
            foreach (var m in r.Matches(s))
                Console.WriteLine(m);


        }
    }
}
