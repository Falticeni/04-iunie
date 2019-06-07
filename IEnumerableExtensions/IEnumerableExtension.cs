using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    public static class IEnumerableExtension
    {
        public static T Sum<T>(this IEnumerable<T> lista)
        {
            dynamic sum = 0;
            foreach (var element in lista)
            {
                sum += element;
            }
            return sum;
        }


        public static T Product<T>(this IEnumerable<T> lista)
        {
            dynamic product = 1;
            foreach (var element in lista)
            {
                product *= element;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> lista) where T : IComparable
        {
            T min = lista.Last();
            foreach (var element in lista)
            {
                if (min.CompareTo(element) > 0)
                {
                    min = element;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> lista) where T : IComparable
        {
           
            T max = lista.Last();
            foreach (var element in lista)
            {
                if (max.CompareTo(element) < 0)
                {
                    max = element;
                }
            }
            return max;
        }

        public static double Average<T>(this IEnumerable<T> lista)
        {
            int count = 0;
            foreach (var element in lista)
            {
                count++;
            }
            return Convert.ToDouble(lista.Sum()) / count;
        }
    }
}
