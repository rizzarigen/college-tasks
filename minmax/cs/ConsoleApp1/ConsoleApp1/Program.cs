using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int a;
            int b;
            double z;

            Console.WriteLine("Введите x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (x < y)
            {
                double minEl = a - Math.Cos(x);
                if (a / (b + y) < minEl)
                {
                    minEl = a / (b + y);
                }
                if (Math.Pow(Math.Sin(y), 2) < minEl)
                {
                    minEl = Math.Pow(Math.Sin(y), 2);
                }
                z = minEl;
                Console.WriteLine("Результат: ");
                Console.WriteLine(z);
            }
            else if (y <= x && x < y + 5)
            {
                double maxEl = Math.Pow(a, 3);

                if (maxEl < Math.Log(Math.Pow(x, 2) + Math.Pow(y, 2)))
                {
                    maxEl = Math.Log(Math.Pow(x, 2) + Math.Pow(y, 2));
                }
                z = maxEl;
                Console.WriteLine("Результат: ");
                Console.WriteLine(z);

            }
            else if (x >= y + 5)
            {
                z = a + Math.Pow(Math.Cos(x - y), 3);
                Console.WriteLine("Результат: ");
                Console.WriteLine(z);
            }

            Console.ReadLine();


        }
    }
}