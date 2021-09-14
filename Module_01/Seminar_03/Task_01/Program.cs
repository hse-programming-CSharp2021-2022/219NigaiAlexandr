using System;

namespace Task_01
{
    class Program
    {
        static bool Function1(bool p, bool q)
        {
            return (!(p & q) & !(p | !q));
        }

        static void Function2(bool p, bool q, ref bool res)
        {
            res = (!(p & q) & !(p | !q));
        }

        static void Main(string[] args)
        {
            bool[] k = { false, true };

            foreach (var i in k)
            {
                foreach (var j in k)
                {
                    Console.WriteLine($"{i} {j} {Function1(i, j)}");
                }
            }

            Console.WriteLine();

            bool res = false;

            foreach (var i in k)
            {
                foreach (var j in k)
                {
                    Function2(i, j, ref res);
                    Console.WriteLine($"{i} {j} {res}");
                }
            }
        }
    }
}
