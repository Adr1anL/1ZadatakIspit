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
            string recenica;
            

            Console.Write("Unesi recenicu: ");
            recenica = Console.ReadLine();

            recenica = recenica.Replace(' ', '_');

            Console.WriteLine(recenica);

            Console.ReadKey();
        }
    }
}
