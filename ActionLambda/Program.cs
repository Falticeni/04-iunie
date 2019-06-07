using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> printActionDel = i => Console.WriteLine(i);

            printActionDel(99);
        }
    }
}
