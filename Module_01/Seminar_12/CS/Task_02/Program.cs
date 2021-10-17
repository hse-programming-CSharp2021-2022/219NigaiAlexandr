using System;
using System.Text.RegularExpressions;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            var regex = new Regex(@"\b\w{4}\b");

            foreach (var m in regex.Matches(s))
            {
                Console.WriteLine(m);
            }
        }
    }
}
