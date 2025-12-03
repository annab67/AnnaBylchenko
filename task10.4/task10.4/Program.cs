using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");

            var n = long.Parse(Console.ReadLine());

            int maxDigit = -1;
            int minIndex = -1;
            int i = -1;

            var numb = n;

            while (numb > 0)
            {
                i++;
                int digit = (int)(numb % 10);
                numb /= 10;

                if (digit >= maxDigit)
                {
                    maxDigit = digit;
                    minIndex = i;
                }
            }

            var result = i + 1 - minIndex;

            Console.WriteLine($"В числе {n} наибольшая первая слева цифра \"{maxDigit}\" - {result}-я");
        }
    }
}
