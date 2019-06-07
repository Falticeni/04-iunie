using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ExtractStudentsByEmail
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<double> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, string fn, string tel, string email, List<double> marks, int groupnumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = new List<double>(marks);
            this.GroupNumber = groupnumber;
        }
    }
}
