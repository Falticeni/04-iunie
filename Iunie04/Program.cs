using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iunie04
{
    class Program
    {
        public delegate void Metoda(int a);

        static void Main(string[] args)
        {
            ////Extensii:            
            //int a = 5;
            //int z = a.Adunare(3);
            //int y = a.Scadere(2);
            //int r = a.Inmultire(5);
            //int q = a.Impartire(2);

            //Console.WriteLine(z);
            //Console.WriteLine(y);
            //Console.WriteLine(r);
            //Console.WriteLine(q);

            ////Delegate
            ///

            Metoda Print;

            Console.WriteLine("Introduceti numarul: ");
            int a = Convert.ToInt16(Console.ReadLine());

            if (a % 2 == 0)
            {
                Print = Colour1;
            }
            else
            {
                Print = Colour2;
            }

           Print(a);

            static void Colour1(int x)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(x + " este numar par.");
            }
            static void Colour2(int x)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(x + " este numar impar.");
            }


            Console.ReadKey();
        }

    }
}

