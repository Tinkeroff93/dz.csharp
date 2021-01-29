using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz16video
{
    class Program
    {
        static void Main(string[] args)
        {
            uint nechetNumber = 0;
            uint chetNumber = 0;

            int nechetNumberSum = 0;
            int chetNumberSum = 0;

            Console.WriteLine("Введите первое число диапозона");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число диапозона");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    chetNumber++;
                    chetNumberSum += currentValue;
                }
                else
                {
                    nechetNumber++;
                    nechetNumberSum = nechetNumberSum + currentValue;
                    
                }
                currentValue++;
            }


            Console.WriteLine("Количество нечётных чисел: " + nechetNumber);
            Console.WriteLine("Количество чётных чисел: " + chetNumber);
            Console.WriteLine("Сумма нечётных чисел: " + nechetNumberSum);
            Console.WriteLine("Сумма чётных чисел: " + chetNumberSum);

            Console.ReadLine();
        }
    }
}
