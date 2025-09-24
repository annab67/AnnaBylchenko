using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Иван Бунин");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Листопад");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Лес, точно терем расписной,");
            Console.WriteLine("Лиловый, золотой, багряный,");
            Console.WriteLine("Веселой, пестрою стеной");
            Console.WriteLine("Стоит над светлою поляной...");

            Console.ResetColor();
        }
    }
}
