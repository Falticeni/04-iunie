using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Lista = new List<string>() { "Robert", "Tudor", "Andrei", "Mihai", "Mina" };
            var literaM = from om in Lista
                          where (om.Contains("m") || om.Contains("M"))
                          select om;
            foreach (var element in literaM)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
