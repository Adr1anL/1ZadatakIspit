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
            string[] stringovi = new string[2];
            Console.WriteLine("Unesi dva stringa: ");
            
            stringovi[0] = Console.ReadLine();
            stringovi[1] = Console.ReadLine();

            Array.Sort(stringovi);

            Console.WriteLine();

            foreach (string word in stringovi)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}
