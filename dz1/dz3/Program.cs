using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    class Program
    {
        static void Main(string[] args)
        {
            double CzkToRub = 3.5;
            double CzkToUsd = 0.047;
            double CZK;

            Console.WriteLine("Введите сумму в CZK");

            CZK = double.Parse(Console.ReadLine());

            Console.WriteLine(CZK + " CZK в RUB = " + CZK * CzkToRub + " Руб.");
            Console.WriteLine(CZK + " CZK в USD =" + " $" + CZK * CzkToUsd );

            Console.ReadLine();
        }
    }
}
