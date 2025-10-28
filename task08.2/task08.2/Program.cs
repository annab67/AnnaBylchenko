using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите абциссу точки");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ординату точки");
            var y = double.Parse(Console.ReadLine());

            if (IfInArea(x, y))
                Console.WriteLine("Точка лежит в указанной области");
            else
                Console.WriteLine("Точка не лежит в указанной области");
        }
        static bool IfInArea(double x, double y) =>
            y >= 0 && x >= 2 || y <= -1 && x >= 1;
    }
}
