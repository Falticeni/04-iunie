using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03FirstBeforeLast
{
    public class Student
    {
        public string FirstName { get; set; }
        public string Name { get; set; }

        public Student(string firstName, string name)
        {
            this.FirstName = firstName;
            this.Name = name;
        }
    }
}
