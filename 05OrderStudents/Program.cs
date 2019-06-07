using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05OrderStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] arr = new Student[] { new Student("Robert", "Ciocan", 27), new Student("Maria", "Ciocan", 18), new Student("Ioan", "Alexandrescu", 22), new Student("Alexandru", "Gutar", 36), new Student("Marcel", "Ata", 20) };
            foreach (Student om in arr)
            {

            }

            Console.WriteLine("Lista studentilor este: ");
            foreach (Student student in arr)
            {
                Console.WriteLine("Name: {0} {1}, Age:{2}", student.FirstName, student.Name, student.Age);
            }

            Console.WriteLine();
            Console.WriteLine("Lista studentilor sortati descrescator cu Lambda Expresion este: ");
            var LamdaStudenti = arr.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.Name);
            foreach (var s in LamdaStudenti)
            {
                Console.WriteLine("Name: {0} {1}, Age: {2}", s.FirstName, s.Name, s.Age);
            }

            var ListaStudenti = from s in arr
                                orderby s.FirstName descending, s.Name descending
                                select s;
            Console.WriteLine();
            Console.WriteLine("Lista studentilor sortati descrescator cu LINQ este: ");
            foreach (var s in ListaStudenti)
            {
                Console.WriteLine("Name: {0} {1}, Age: {2}", s.FirstName, s.Name, s.Age);
            }
        }
    }
}
