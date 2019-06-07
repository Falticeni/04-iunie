using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<double> arr = new double [] { 10, 20, 30, 40, 55, 60, 99 };
            
            
            Console.WriteLine("Suma numerelor este: {0}. ", arr.Sum());
            Console.WriteLine("Produsul numerelor este: {0}. ", arr.Product());
            Console.WriteLine("Minimul numerelor este: {0}. ", arr.Min());
            Console.WriteLine("Maximul numerelor este: {0}. ", arr.Max());
            Console.WriteLine("Media numerelor este: {0}. ", arr.Average());
        }
    }
}
