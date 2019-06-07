using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementFunc1
{
    class Program
    {
        public delegate int SomeOperation(int i, int j);
        static void Main(string[] args)
        {
            SomeOperation add = Sum;

            int result = add(10, 10);

            Console.WriteLine(result);
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
