using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05OrderStudents
{
    class Student
    {
        public string FirstName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string firstName, string name, int age)
        {
            this.FirstName = firstName;
            this.Name = name;
            this.Age = age;
        }
    }
}
