using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите k (k >= 2): ");
            int k = int.Parse(Console.ReadLine());

            if (k < 2)
            {
                Console.WriteLine("k должно быть больше или равен 2!");
                return;
            }

            Console.WriteLine($"Числа от {a} до {b}, у которых количество делителей равно {k}:");

            for (int number = a; number <= b; number++)
            {
                if (GetTotalDivisorsCount(number) == k)
                {
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine();
        }

        static int GetTotalDivisorsCount(int n)
        {
            int count = 0;
            for (int d = 1; d <= n; d++)
            {
                if (n % d == 0)
                    count++;
            }
            return count;
        }
    }
}