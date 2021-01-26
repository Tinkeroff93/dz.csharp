using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2;

            Console.WriteLine("Введите первое число:");

            number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");

            number2 = double.Parse(Console.ReadLine());

            double result = (number1 + number2) / 2;

            Console.WriteLine("Среднее арифметическое Ваших двух чисел = " + result);

            Console.ReadLine();

        }
    }
}
