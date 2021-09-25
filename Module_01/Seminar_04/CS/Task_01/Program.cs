using System;
using System.Collections.Generic;

namespace Task_01
{
    class Program
    {
        static bool Transform(ref uint numb)
        {
            if (numb.ToString().Length != 3) return false;
            var digits = new List<uint>();
            while (numb > 0)
            {
                digits.Add(numb % 10);
                numb /= 10;
            }
            digits.Sort();
            numb = digits[2] * 100 + digits[1] * 10 + digits[0];
            return true;
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                uint a = uint.Parse(Console.ReadLine());
                Transform(ref a);
                Console.WriteLine(a);
            }
        }
    }
}
