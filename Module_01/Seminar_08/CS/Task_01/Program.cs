using System;

namespace Task_01
{
    class Program
    {
        static void Print(int[][] arr)
        {
            foreach (var i in arr)
            {
                foreach (var j in i)
                {
                    Console.Write($"{j} ");
                }

                Console.WriteLine();
            }
        }
        
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var rand = new Random();
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[rand.Next(5, 16)];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(-10, 11);
                }
            }
            
            Print(arr);
            
            Array.ForEach(arr, ints =>
            {
                Array.Sort(ints);
                Array.Reverse(ints);
            });
            
            Array.Sort(arr, (ints, ints1) =>
            {
                if (ints.Length > ints1.Length) return 1;
                if (ints.Length < ints1.Length) return -1;
                return 0;
            });
            Console.WriteLine();
            Print(arr);
        }
    }
}