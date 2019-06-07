using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action1A
{
    class Program
    {
        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            Action<int> printActionDel = ConsolePrint;
            //or
            //Action<int> printActionDel = new Action<int>(ConsolePrint);

            printActionDel(10);
        }
    }
}
