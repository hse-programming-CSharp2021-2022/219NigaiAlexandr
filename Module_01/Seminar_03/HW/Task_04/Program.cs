using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            for (int i = 0; i < 3; i++) 
                list.Add(int.Parse(Console.ReadLine()));

            var minCabNum = list.Min(x => x % 100);
            bool flag = true;
            foreach (var i in list.Where(x => x % 100 == minCabNum))
            {
                if (flag)
                {
                    Console.WriteLine(i);  
                    break;
                }
                
            }
            
        }
    }
}