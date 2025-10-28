using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите число");
            //double x = double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите еще одно число");
            //double y = double.Parse(Console.ReadLine());

            //bool z = x > y;
            //bool w = x + y >= x* y;

            //Console.WriteLine($"z = {z}, w = {w}");

            //bool left = !(z && w);
            //bool right = !z || !w;

            //Console.WriteLine(left == right);

            Console.WriteLine("Введите целое число");
            var k = int.Parse(Console.ReadLine());
            Console.WriteLine($"k = {Convert.ToString(k, 2)}");
            Console.WriteLine("Введите еще одно целое число");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"k = {Convert.ToString(n, 2)}");


            Console.WriteLine(k & n);
            Console.WriteLine($"k & n = {Convert.ToString(k & n, 2)}");


        }
    }
}
