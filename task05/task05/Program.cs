using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Calculate(2, 3, 4, 5);
            Console.WriteLine(Math.Round(x, 3));
            
        }
        static double Calculate(double a, double b, double c, double d) =>
                Math.Sqrt(a + Math.Sqrt(b + Math.Sqrt(c + Math.Sqrt(d))));
    }
}
