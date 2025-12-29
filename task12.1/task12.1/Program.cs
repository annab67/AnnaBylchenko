using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;

            while (true)
            {
                Console.WriteLine("Введите через пробел два натуральных числа m и n от 5 до 20");
                Console.WriteLine("(Enter - отказ от ввода)");
                var input = Console.ReadLine();

                if (input == string.Empty)
                    return;

                var strings = input.Split();

                if (strings.Length == 2 && int.TryParse(strings[0], out m) &&
                    int.TryParse(strings[1], out n) && 5 <= m && m <= 20 &&
                    5 <= n && n <= 20)
                    break;
                else
                {
                    Console.WriteLine("Ошибка ввода");
                    continue;
                }
            }

            var matrix = new int[m, n];

            var rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(0, 100);

            Console.WriteLine("\nСгенерированный массив:");
            PrintTable(matrix);
            Console.WriteLine();

            // Задача (a)
            var violation = CheckRowsAscending(matrix);

            if (violation.rowIndex >= 0)
                Console.WriteLine($"Нарушение порядка: строка {violation.rowIndex}, " +
                    $"столбцы {violation.colIndex} и {violation.colIndex + 1}");
            else
                Console.WriteLine("Все строки массива упорядочены по возрастанию");

            Console.WriteLine();

            // Задача (b)
            var sums = GetOddElementsSums(matrix);

            Console.WriteLine("Суммы нечетных элементов по столбцам:");
            for (int j = 0; j < sums.Length; j++)
            {
                Console.WriteLine($"Столбец {j}: {sums[j]}");
            }
        }

        static void PrintTable(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                    Console.Write($"{table[i, j],3} ");

                Console.WriteLine();
            }
        }

        static (int rowIndex, int colIndex) CheckRowsAscending(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1) - 1; j++)
                {
                    if (table[i, j] >= table[i, j + 1])
                    {
                        return (i, j);
                    }
                }
            }

            return (-1, -1);
        }

        static int[] GetOddElementsSums(int[,] table)
        {
            var result = new int[table.GetLength(1)];

            for (int j = 0; j < table.GetLength(1); j++)
            {
                int sum = 0;

                for (int i = 0; i < table.GetLength(0); i++)
                {
                    if (table[i, j] % 2 != 0)
                    {
                        sum += table[i, j];
                    }
                }

                result[j] = sum;
            }

            return result;
        }
    }
}