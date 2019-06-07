using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Ce-mi mai place informatica! :))");
            Console.WriteLine(sb1.Substring(0, 9));
        }
    }
}
