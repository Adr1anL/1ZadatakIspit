using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double broj1 = 0;
            double broj2 = 0;

            Console.WriteLine("Unesi broj: ");
            broj2 = Convert.ToDouble(Console.ReadLine());

            do
            {
                double x = broj1 + broj2;
                Console.WriteLine(x);
                broj1 = broj2;
                broj2 = x;
                System.Threading.Thread.Sleep(500);

            }while(true);

        }
    }
}
