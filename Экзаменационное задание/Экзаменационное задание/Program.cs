using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Экзаменационное_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limit = 1000;
            var isGenerated = new bool[limit + 1];

            // проходим по всем числам до 1000 и помечаем их порождения
            for (int i = 1; i <= limit; i++)
            {
                var generated = i + GetDigitsSum(i);

                if (generated <= limit)
                    isGenerated[generated] = true;
            }

            Console.WriteLine("Самопорожденные числа меньше 1000:");

            for (int i = 1; i < limit; i++)
            {
                if (!isGenerated[i])
                    Console.Write($"{i}, ");
            }

            Console.WriteLine("\b\b.\n"); // после последнего числа ставим "."
        }

        static int GetDigitsSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}