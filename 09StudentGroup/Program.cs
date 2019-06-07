using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> ListaStudenti = new List<Student> { new Student("Robert", "Ciocan", "012", "0747611338", "robertciocan@yahoo.com", new List<double> { 10, 10, 10, 10 }, 1 ),
                                                              new Student("Maria", "Ciocan", "013", "0747618338", "mariaciocan@yahoo.com", new List<double> { 9, 10, 9, 10 }, 2),
                                                              new Student("Ioan", "Alexandrescu", "014", "0722611338", "ioanalexandrescu@yahoo.com", new List<double> { 7, 8, 9, 10 }, 1),
                                                              new Student("Alexandru", "Gutar", "012", "0747611228", "alexandrugutar@yahoo.com", new List<double> { 10,9, 8, 7 }, 1),
                                                              new Student("Marcel", "Ata", "012", "0747699338", "marcelatat@yahoo.com", new List<double> { 10, 9, 10, 10 }, 2)
                                                            };

            Console.WriteLine("Lista studentilor este: ");
            foreach (Student student in ListaStudenti)
            {
                Console.WriteLine("Name: {0} {1}. ", student.FirstName, student.LastName);
            }
            Console.WriteLine();

            Console.WriteLine("Lista studentilor din grupa numarul 2 este: ");
            var Lista1 = from s in ListaStudenti
                         where s.GroupNumber == 2
                         select s;
            foreach (var s in Lista1)
            {
                Console.WriteLine("Name: {0} {1}, GroupNumber: {2}.", s.FirstName, s.LastName, s.GroupNumber);
            }
            Console.WriteLine();

            Console.WriteLine("Lista studentilor din grupa numarul 2, ordonati dupa prenume este: ");
            var Lista2 = from s in Lista1
                         orderby s.FirstName
                         select s;
            foreach (var s in Lista2)
            {
                Console.WriteLine("Name: {0} {1}, GroupNumber: {2}.", s.FirstName, s.LastName, s.GroupNumber);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
