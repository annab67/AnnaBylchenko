using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел");
            var n = int.Parse(Console.ReadLine());

            double product = 1;

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine($"Введите {i + 1}-е число");
                product *= int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Произведение = {product}");
        }
    }
}