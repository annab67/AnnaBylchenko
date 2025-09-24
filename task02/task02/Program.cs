using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            var a = double.Parse(Console.ReadLine());

            var volume = Math.Pow(a, 3);
            var diag = Math.Sqrt(3 * Math.Pow(a, 2));

            Console.WriteLine("Объем куба равен " + volume);
            Console.WriteLine("Диагональ куба равна " + diag);

        }
    }
}
