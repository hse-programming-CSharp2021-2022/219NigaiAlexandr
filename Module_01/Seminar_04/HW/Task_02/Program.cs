using System;

namespace Task_02
{
    class Program
    {
        static bool Shift(ref char ch)
        {
            int newCh;
            if (ch >= 97 && ch <= 122)
            {
                if (ch + 4 > 122) newCh = ch - 22;
                else newCh = ch + 4;
                ch = (char)newCh;
                return true;
            }
            return false;
        }
        public static void Main (string[] args) 
        {
            char k;
            while(true)
            {
                k = Convert.ToChar(Console.ReadLine());
                if (Shift(ref k)) Console.WriteLine(k);
            }
        } 
    }
}