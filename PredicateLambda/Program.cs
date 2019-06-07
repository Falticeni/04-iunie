using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpper = s => s.Equals(s.ToUpper());
            bool result = isUpper("hello world!!");
            Console.WriteLine(result);
        }
    }
}
