using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            double x;
            double y;
            double h = Math.PI / 8;

            Console.WriteLine("-------------------------------------");

            for (x = -Math.PI; x <= Math.PI; x += h)
            {
                y = (1 / (x + 2 * Math.PI)) - Math.Sin(x);
                sum += y;
                Console.WriteLine("x=" + x + "; y=" + y);

            }

            Console.WriteLine("Сумма: ");
            Console.WriteLine(sum);

            Console.WriteLine("-------------------------------------");

            x = -Math.PI;
            sum = 0;

            while (x <= Math.PI)
            {
                y = (1 / (x + 2 * Math.PI)) - Math.Sin(x);
                sum += y;
                Console.WriteLine("x=" + x + "; y=" + y);
                x += h;
            }

            Console.WriteLine("Сумма: ");
            Console.WriteLine(sum);

            Console.WriteLine("-------------------------------------");

            x = -Math.PI;
            sum = 0;

            do
            {
                y = (1 / (x + 2 * Math.PI)) - Math.Sin(x);
                sum += y;
                Console.WriteLine("x=" + x + "; y=" + y);
                x += h;
            } while (x <= Math.PI);

            Console.WriteLine("Сумма: ");
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
