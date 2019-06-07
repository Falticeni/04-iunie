using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateAnonymus
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpper = delegate (string s) { return s.Equals(s.ToUpper()); };
            bool result = isUpper("hello world!!");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
