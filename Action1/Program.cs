using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action1
{
    public delegate void Print(int val);
    class Program
    {
        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
            static void Main(string[] args)
        {
            Print prnt = ConsolePrint;
            prnt(10);
        }
    }
}
