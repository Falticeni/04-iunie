using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03FirstBeforeLast
{
    class Program
    {

        static void Main(string[] args)
        {
            Student[] arr = new Student[] { new Student("Robert", "Ciocan"), new Student("Maria", "Popescu"), new Student("Ioan", "Alexandrescu"), new Student("Alexandru", "Gutar"), new Student("Marcel", "Ata") };
            foreach (Student om in arr)
            {

            }

            Console.WriteLine("Lista studentilor este: ");
            foreach (Student student in arr)
            {
                Console.WriteLine("First Name: {0}, Name: {1}", student.FirstName, student.Name);
            }

            var ListaStudenti = from s in arr
                                where string.Compare(s.FirstName, s.Name) < 0
                                select s;
            Console.WriteLine();
            Console.WriteLine("Lista actualizata a studentilor este: ");
            foreach (var s in ListaStudenti)
            {
                Console.WriteLine("First Name: {0}, Name: {1}", s.FirstName, s.Name);
            }
        }
    }
}
