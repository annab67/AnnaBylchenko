using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число > 1");

            var a = double.Parse(Console.ReadLine());

            long n = 0;
            double sum = 0;
            double power = -1.0 / 2;

            while (sum <= a)
            {
                n++;
                sum += Math.Pow(n, power);
            }

            Console.WriteLine($"Сумма > {a} при n = {n}");
        }
    }
}
