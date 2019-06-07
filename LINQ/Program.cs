using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> s = new List<Student> { new Student(20), new Student(21), new Student(17), new Student(18) },
            s = > s.age > 18;

        }

        
    }
}
