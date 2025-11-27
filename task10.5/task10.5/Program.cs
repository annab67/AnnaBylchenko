using System;

namespace Task10_5
{
    internal class Program
    {
        static double a, b, c;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент a > 0");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b > 0");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c > 0");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите точность вычислений");
            var epsilon = double.Parse(Console.ReadLine());

            // Находим левую границу отрезка [-n; 0]
            int n = 1;
            while (F(-n) >= 0)  // Пока f(-n) не станет отрицательным
            {
                n++;
            }

            // Теперь отрезок [-n; 0] содержит корень
            double result = GetRoot(-n, 0, epsilon);

            Console.WriteLine($"Корень уравнения f(x) = 0 равен {result:F5}");
        }

        static double GetRoot(double left, double right, double epsilon)
        {
            if (left >= right)
                throw new ArgumentException("Должно быть left < right");

            double center = 0;

            while (right - left >= epsilon)
            {
                center = (left + right) / 2;

                var f = F(center);

                if (Math.Abs(f) < epsilon)
                    break;

                if (f > 0)
                    left = center;
                else
                    right = center;
            }

            return center;
        }

        static double F(double x) => x * x * x + a * x * x + b * x + c;
    }
}