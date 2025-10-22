using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace task08._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число n");
            var n = int.Parse(Console.ReadLine());

            if (IfLogicalExpressionTrue(n))
                Console.WriteLine("Число n кратно 5, но не кратно 7");
            else
                Console.WriteLine("Либо число n не кратно 5, либо кратно 7");
        }

        static bool IfLogicalExpressionTrue(int n) =>
            (n % 5 == 0) && (n % 7 != 0);
    }
}
