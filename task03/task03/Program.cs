using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время в формате h m (1<=h<=12, 0<=m<=59):");
            var h = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            int minutes = (h * 5 - m + 60) % 60;

            Console.WriteLine("Наименьшее оставшееся время (мин): " + minutes);
        }
    }
}
