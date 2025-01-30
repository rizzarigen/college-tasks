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

            double peri(int n, int R)
            {
                double degrad = (180 / n) * (Math.PI / 180);
                return 2 * R * Math.Sin(degrad);
            }

            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Периметр 10-тиугольника: " + peri(10, 100));
            Console.WriteLine("Периметр 50-тиугольника: " + peri(50, 100));
            Console.WriteLine("Периметр 100угольника: " + peri(100, 100));
            Console.ReadLine();

        }
    }
}