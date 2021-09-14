using System;

namespace Task_02
{
    class Program
    {
        static void ForLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * i);
            }
        }

        static void WhileLoop()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i * i);
                i++;
            }
        }

        static void DoLoop()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i * i);
                i++;
            } while (i <= 10);
        }

        static void Main(string[] args)
        {
            ForLoop();
            WhileLoop();
            DoLoop();
        }
    }
}
