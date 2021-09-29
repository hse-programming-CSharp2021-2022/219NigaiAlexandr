using System;

namespace Task_06
{
    class Program
    {
        static int[] Foo(int[] a)
        {

            int[] b = new int[a.Length];
            int k = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if ((a[i] + a[i + 1]) % 3 == 0)
                {
                    b[k] = a[i] * a[i + 1];
                    k++;
                }
            }

            return b;
        }
        
        static void Main(string[] args)
        {
            int[] a = new int [] {3, 4, 5, 7, 20};

            foreach (var i in Foo(a))
            {
                if (i != 0) Console.Write($"{i} ");
            }
        }
    }
}