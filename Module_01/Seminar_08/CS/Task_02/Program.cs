using System;

namespace Task_02
{
    class Program
    {
        static void Print(int[,] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            var rand = new Random();

            int cnt = 0, min, max;
            int[,] maxMinArray = new int[n ,n];
            for (int i = 0; i < n; i++)
            {
                max = -21;
                min = 21;
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(-20, 21);
                    if (matrix[i, j] % 2 == 0) cnt++;
                    if (matrix[i, j] > max) max = matrix[i, j];
                    if (matrix[i, j] < min) min = matrix[i, j];
                }

                maxMinArray[i, 0] = max;
                maxMinArray[i, 1] = min;
            }
            
            Print(matrix, n);
            Console.WriteLine();
            Console.WriteLine(cnt);
            Print(maxMinArray, 2);
        }
    }
}