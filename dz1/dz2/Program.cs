using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, number3;

            Console.WriteLine("Введите первое число:");

            number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");

            number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число:");

            number3 = double.Parse(Console.ReadLine());

            double sumResult = number1 + number2 + number3;

            double multResult = number1 * number2 * number3;

            Console.WriteLine("Сумма Ваших трех чисел = " + sumResult);

            Console.WriteLine("Произведение Ваших трех чисел = " + multResult);

            Console.ReadLine();
        }
    }
}
