using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int length = 15;

            Console.WriteLine("Введите натуральное число b");
            int b = int.Parse(Console.ReadLine());

            // 1) Заполнение массива первыми 15 членами a_n = 2^n - b
            var numbers = new int[length];

            int currentPowerOfTwo = 1;          
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = currentPowerOfTwo - b;
                currentPowerOfTwo *= 2;         
            }

            Console.WriteLine("Исходный массив:");
            PrintIntArray(numbers);

            // 2) Меняем знак элементов с нечетным индексом
            ChangeSignOfOddIndex(numbers);
            Console.WriteLine("Массив после изменения знака элементов с нечетным индексом:");
            PrintIntArray(numbers);

            // 3) Среднее арифметическое элементов массива
            double average = GetAverage(numbers);
            Console.WriteLine($"Среднее арифметическое элементов: {average:F3}\n");

            // 4) Массив остатков от деления на k (исходный не изменяем)
            Console.WriteLine("Введите число k");
            int k = int.Parse(Console.ReadLine());

            var remainders = GetRemainders(numbers, k);
            Console.WriteLine("Массив остатков от деления на k:");
            PrintIntArray(remainders);
        }

        static void PrintIntArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write("; ");
                }
            }
            Console.WriteLine("\n");
        }

        static void ChangeSignOfOddIndex(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    array[i] = -array[i];
                }
            }
        }

        static double GetAverage(int[] array)
        {
            if (array.Length == 0)
                return 0;

            long sum = 0;
            foreach (var item in array)
                sum += item;

            return (double)sum / array.Length;
        }

        static int[] GetRemainders(int[] array, int k)
        {
            var result = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (k == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    return result; 
                }
                result[i] = array[i] % k;
            }

            return result;
        }
    }
}