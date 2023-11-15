using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prosjek = 0;

            Console.Write("Unesi broj članova niza: ");
            int x = Convert.ToInt32(Console.ReadLine());

            double[] niz = new double[x];

            for (int i = 0; i < x; i++)
            {
                niz[i] = Convert.ToDouble(Console.ReadLine());
                prosjek += niz[i];
            }

            prosjek /= niz.Length;
            double min = niz[0];

            for (int i = 0;i < x; i++)
            {
                if (niz[i] < min)
                    min = niz[i];
            }

            Console.WriteLine("Prosjek : " + prosjek);
            Console.WriteLine("Najmanji: " + min);

            Console.ReadKey();
        }
    }
}
