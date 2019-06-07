using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> getRandomNumber = () => new Random().Next(1, 100);
            // or
            //Func<int, int, int> Sum = (x, y) => x + y;

            Console.WriteLine(getRandomNumber());
            //Console.WriteLine(Sum(3, 4));

            Console.ReadKey();
        }
    }
}
