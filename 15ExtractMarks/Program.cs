using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15ExtractMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> ListaStudenti = new List<Student> { new Student("Robert", "Ciocan", "012006", "0747611338", "robertciocan@gmail.com", new List<double> { 10, 10, 10, 10 }, 1 ),
                                                              new Student("Maria", "Ciocan", "012005", "0747618338", "mariaciocan@yahoo.com", new List<double> { 9, 10, 9, 10 }, 2),
                                                              new Student("Ioan", "Alexandrescu", "012005", "0722611338", "ioanalexandrescu@gmail.com", new List<double> { 7, 8, 9, 9 }, 1),
                                                              new Student("Alexandru", "Gutar", "012006", "0044747611228", "alexandrugutar@yahoo.com", new List<double> { 9, 9, 8, 7 }, 1),
                                                              new Student("Marcel", "Ata", "012006", "0747699338", "marcelatat@gmail.com", new List<double> { 10, 9, 10, 10 }, 2)
                                                            };


            Console.WriteLine("Lista studentilor inregistrati in 2006 este: ");
            var Student2006 = ListaStudenti.Where(stud => stud.FN[4] == '0' && stud.FN[5] == '6');

            foreach (Student s in Student2006)
            {
                Console.WriteLine("Name: {0} {1}/ FN: {2}", s.FirstName, s.LastName, s.FN);
            }

            Console.ReadKey();
        }
    }
}
