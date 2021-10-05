using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[n];
            }

            int k = 1;
            for (int j = 0; j < n; j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        arr[j][i] = k++;
                    }
                }

                else
                {
                    for (int i = n - 1; i >= 0; i--)
                    {
                        arr[j][i] = k++;
                    }
                }
            }

            foreach (var i in arr)
            {
                foreach (var j in i)
                {
                    Console.Write($"{j} ");
                } 
                Console.WriteLine();
            }
        }
    }
}