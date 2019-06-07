using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ExctractStudentByPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> ListaStudenti = new List<Student> { new Student("Robert", "Ciocan", "012", "0747611338", "robertciocan@gmail.com", new List<double> { 10, 10, 10, 10 }, 1 ),
                                                              new Student("Maria", "Ciocan", "013", "0747618338", "mariaciocan@yahoo.com", new List<double> { 9, 10, 9, 10 }, 2),
                                                              new Student("Ioan", "Alexandrescu", "014", "0722611338", "ioanalexandrescu@gmail.com", new List<double> { 7, 8, 9, 10 }, 1),
                                                              new Student("Alexandru", "Gutar", "012", "0044747611228", "alexandrugutar@yahoo.com", new List<double> { 10,9, 8, 7 }, 1),
                                                              new Student("Marcel", "Ata", "012", "0747699338", "marcelatat@gmail.com", new List<double> { 10, 9, 10, 10 }, 2)
                                                            };


            Console.WriteLine("Lista studentilor este: ");
            foreach (Student student in ListaStudenti)
            {
                Console.WriteLine("Name: {0} {1}/ Telefon: {2}. ", student.FirstName, student.LastName, student.Tel);
            }
            Console.WriteLine();


            Console.WriteLine("Lista studentilor cu numar de Anglia este: ");
            var Lista1 = ListaStudenti.Where(x => x.Tel.Contains("0044"));
            foreach (var s in Lista1)
            {
                Console.WriteLine("Name: {0} {1}/ Telefon: {2}.", s.FirstName, s.LastName, s.Tel);
            }


            Console.ReadKey();
        }
    }
}
