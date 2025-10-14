using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово 'трос':");
            string word = Console.ReadLine();

            string first_word = word.Substring(3, 1) +
                          word.Substring(2, 1) +
                          word.Substring(1, 1) +
                          word.Substring(0, 1);

            string second_word = word.Substring(1, 2) +
                          word.Substring(3, 1) +
                          word.Substring(0, 1);

            Console.WriteLine("Первое слово: " + first_word);
            Console.WriteLine("Второе слово: " + second_word);
        }
    }
}
