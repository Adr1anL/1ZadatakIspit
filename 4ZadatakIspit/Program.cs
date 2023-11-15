using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;

        pocetak: Console.Write("Unesi a, b, c sa razmacima: ");
            string[] temp = Console.ReadLine().Split(' ');

            try
            {
                a = Convert.ToDouble(temp[0]);
                b = Convert.ToDouble(temp[1]);
                c = Convert.ToDouble(temp[2]);

            }
            catch (Exception)
            {
                Console.WriteLine("Nevazeci znak upisan!");
                Console.ReadKey();
                return;
            }

            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)){
                Console.WriteLine("Trokut je pravokutan!");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Trokut nije pravokutan!");
                Console.ReadKey();
                return;
            }
        }
    }
}
