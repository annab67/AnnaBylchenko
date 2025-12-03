using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");

            int b;

            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка ввода");
            }

            if(b == 0)
            {
                Console.WriteLine("Число не должно быть равно 0");
                return;
            }

            int sum = 0;

            var lowBorder = -b;

            for (int a = lowBorder; a <= b; a++)
                sum += a * a;

            Console.WriteLine($"Сумма квадратов чисел от {lowBorder} до {b*b} равна {sum}");
            
        }
    }
}
