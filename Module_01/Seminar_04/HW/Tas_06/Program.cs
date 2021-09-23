using System;

namespace Tas_06
{
    class Program
    {
        static int Fact(int n)
        {
            int res = 1;
            for (int i = 1; i <= n; i++) res *= i;
            return res;
        }

        static double s1(double x)
        {
            double res = 0;
            for (int i = 1; i < 12; i++)
            {
                res += (Math.Pow(x, i * 2) * Math.Pow(2, i * 2 - 1) / Fact(i * 2)) * Math.Pow(-1, i + 1);
            }

            return res;
        }

        static double s2(double x)
        {
            double res = 1;
            for (int i = 1; i < 35; i++)
            {
                res += Math.Pow(x, i) / Fact(i);
            }

            return res;
        }
        public static void Main (string[] args) {

            Console.WriteLine(s2(2));
        } 
    }
}