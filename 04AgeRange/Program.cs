using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04AgeRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] arr = new Student[] { new Student("Robert", "Ciocan", 27), new Student("Maria", "Popescu", 18), new Student("Ioan", "Alexandrescu", 22), new Student("Alexandru", "Gutar", 36), new Student("Marcel", "Ata", 20) };
            foreach (Student om in arr)
            {

            }

            Console.WriteLine("Lista studentilor este: ");
            foreach (Student student in arr)
            {
                Console.WriteLine("Name: {0} {1}, Age:{2}", student.FirstName, student.Name, student.Age);
            }

            var ListaStudenti = from s in arr
                                where s.Age > 17 && s.Age < 24
                                select s;
            Console.WriteLine();
            Console.WriteLine("Lista studentilor majori dar pana in 24 ani este: ");
            foreach (var s in ListaStudenti)
            {
                Console.WriteLine("Name: {0} {1}, Age: {2}", s.FirstName, s.Name, s.Age);
            }
        }
    }
}
