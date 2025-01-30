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

            double[] x = { 5, -2, 0, 3, 4, 12, 7 };

            int count = 0;

            double mid = 0;

            for (int i = 0; i <= x.Length - 1; i++)
            {
                if (x[i] > 0)
                {
                    mid += x[i];
                    count++;
                }
            }

            mid /= count;

            Console.WriteLine("Среднее арифметическое: " + mid);

            for (int i = 0; i <= x.Length - 1; i++)
            {
                if (x[i] > mid)
                {
                    x[i] = mid;
                }
                Console.WriteLine(x[i]);
            }

            
            Console.ReadLine();


        }
    }
}
