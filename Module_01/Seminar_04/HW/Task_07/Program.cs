using System;

namespace Task_07
{
    class Program
    {
        static int GCD(int a, int b)
        {
            if (a < b) return GCD(b, a);
            else if (b > 0) return GCD(b, a % b);
            else return a;
        }

        static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        static void NodAndNok(int a, int b, out int gcd, out int lcm)
        {
            int k = a;
            gcd = GCD(a, b);
            lcm = LCM(k, b);
        }
        public static void Main (string[] args) {

            Console.WriteLine(LCM(10, 15));
            Console.WriteLine(LCM(18, 27));
        } 
    }
}