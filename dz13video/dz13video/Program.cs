using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz13video
{
    class Program
    {
        static void Main(string[] args)

        {
            int number;

            Console.WriteLine("Введите Ваше число:");

            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Ваше число чётное");
            }
            else
            {
                Console.WriteLine("Ваше число нечётное");
            }

            Console.ReadLine();
        }
    }
}
