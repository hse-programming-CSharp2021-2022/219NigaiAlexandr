using System;
using System.IO;
using System.Text;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Data.txt";

            if (!File.Exists(path)) File.Create(path);

            // Создаем файл с данными
            if (File.Exists(path))
            {
                // Сейчас данные для записи вбиты в коде
                // TODO1: сохранить в файл целые случайные значения из диапазона [10;100)
                var rand = new Random();
                int[] randomNumbers = new int[9];
                for (int i = 0; i < 9; i++)
                {
                    randomNumbers[i] = rand.Next(10, 100);
                }
                string createText = $"{randomNumbers[0]} {randomNumbers[1]}" +
                    $" {randomNumbers[2]} {randomNumbers[3]} {randomNumbers[4]}"
                    + Environment.NewLine + $"{randomNumbers[5]} {randomNumbers[6]}" +
                    $" {randomNumbers[7]} {randomNumbers[8]}";
                File.WriteAllText(path, createText, Encoding.UTF8);
            }

            // Open the file to read from
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                string[] stringValues = readText.Split(' ');
                int[] arr = StringArrayToIntArray(stringValues);
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }

                int[] oddIndexes = new int[arr.Length];
                int[] evenIndexes = new int[arr.Length];

                for (int i = 0, n = 0, m = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        evenIndexes[n] = i;
                        n++;
                    }
                    else
                    {
                        oddIndexes[m] = i;
                        m++;
                        arr[i] = 0;
                    }
                }

                // обрабатываем элементы массива
                // TODO2: Создать два массива по исходному
                // в первый поместить индексы чётных элементов, во второй - нечётных
                // TODO3: Заменяем все нечётные числа исходного массива нулями
            }
        } // end of Main()
        // преобразование массива строк в массив целых чисел
        public static int[] StringArrayToIntArray(string[] str)
        {
            int[] arr = null;
            if (str.Length != 0)
            {
                arr = new int[0];
                foreach (string s in str)
                {
                    int tmp;
                    if (int.TryParse(s, out tmp))
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = tmp;
                    }
                } // end of foreach (string s in str)      
            }
            return arr;
        } // end of StringToIntArray()
    }
}
