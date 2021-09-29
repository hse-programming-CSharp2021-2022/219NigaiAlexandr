using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                sum += Convert.ToSingle(1d / (i * (i + 1) * (i + 2)));
            }
            Console.WriteLine(sum);
        }
    }
}