using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    public struct Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string studentFirst, string studentLast)
            :this()
        {
            this.FirstName = studentFirst;
            this.LastName = studentLast;
        }

        public Student(string studentFirst, string studentLast, int studentAge)
            : this(studentFirst, studentLast)
        {
            this.FirstName = studentFirst;
            this.LastName = studentLast;
            this.Age = studentAge;
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
    }
}