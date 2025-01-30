using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            double f = (((Math.PI / 3) + Math.Log(x ^ 3)) / (3 * y - x)) + (x * Math.Sin(y ^ 2));

            double i = f;
            double j = Math.Floor(f);

            Console.WriteLine("i = " + i);
            Console.WriteLine("j = " + j);

            Console.ReadLine();

        }
    }
}
