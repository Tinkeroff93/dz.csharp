using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz15video
{
    class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {
                Console.Clear();
                double number1, number2;
                string action;

                try
                {
                    Console.WriteLine("Введите Ваше первое число");
                    number1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите Ваше второе число");
                    number2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Проверьте правильность ввода чисел!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(number1 + number2);
                        break;
                    case "-":
                        Console.WriteLine(number1 - number2);
                        break;
                    case "*":
                        Console.WriteLine(number1 * number2);
                        break;
                    case "/":
                        if (number2 == 0)
                            Console.WriteLine("На ноль делить нельзя!");
                        else
                            Console.WriteLine(number1 / number2);
                        break;
                    default:
                        Console.WriteLine("Ошибка! Неизвестное действие!");
                        break;
                }
                Console.ReadLine();
           } 
        } 
    }
}
