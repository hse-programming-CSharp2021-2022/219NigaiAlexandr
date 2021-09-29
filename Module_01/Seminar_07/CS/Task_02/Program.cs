using System;

namespace Task_02
{
    class Program
    {
        static void Print(int[] arr)
        {
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            var rand = new Random();
            

            int[] arr = new int[99];
            
            for (int i = 0; i < 99; i++)
            {
                arr[i] = i + 1;
            }

            arr[rand.Next(0, 100)] = 0;
            
            Array.Sort(arr, (int a, int b) =>
            {
                if (a == 0) return 1;
                if (b == 0) return -1;
                return rand.Next(-1, 2);
            });
            
            Print(arr);
            for (int i = 1; i < 101; i++)
            {
                if (!Array.Exists(arr, x => i == x))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}