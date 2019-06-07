using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iunie04
{
    public static class Decimal
    {
        public static int Adunare(this int a, int b)
        {
            return a + b;
        }

        public static int Scadere(this int a, int b)
        {
            return a - b;
        }
        public static int Inmultire(this int a, int b)
        {
            return a * b;
        }
        public static int Impartire(this int a, int b)
        {
            return a / b;
        }
    }
}
