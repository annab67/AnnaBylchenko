using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите действительное число");
            var x = double.Parse(Console.ReadLine());
            var y = F(x);

            Console.WriteLine("y = " + y);
        }
        static double F(double x)
        {
            return Math.Sqrt((2*x + Math.Sin(Math.Abs(3 * x))) / 3.56);
        }

    }
}
