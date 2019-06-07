using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06DivisibleBy7And3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Lista = new int[] { 1, 2, 3, 4, 21, 42, 63, 78, 79, 80, 1000 };
            Console.Write("Numerele listei sunt: ");
            foreach (var numar in Lista)
            {
                Console.Write(numar + " ");
            }
            Console.WriteLine();

            Console.Write("Lambda: Numerele divizbile cu 7 si 3, din lista, sunt: ");
            var Lambda = Lista.Where(x => x % 21 == 0);
            foreach (var numar in Lambda)
            {
                Console.Write(numar + " ");
            }
            Console.WriteLine();

            Console.Write("LINQ: Numerele divizbile cu 7 si 3, din lista, sunt: ");
            var LINQ = from n in Lista
                       where n % 21 == 00
                       select n;
            foreach (var numar in LINQ)
            {
                Console.Write(numar + " ");
            }
            Console.WriteLine();

        }
    }
}
