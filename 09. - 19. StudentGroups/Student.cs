namespace StudentGroups
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string fN;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public Student(string firstN, string lastN, string facNum, string telNum, string mail, int groupNum, params int[] marks)
        {
            this.FirstName = firstN;
            this.LastName = lastN;
            this.FN = facNum;
            this.Tel = telNum;
            this.Email = mail;
            this.GroupNumber = groupNum;
            this.Marks = new List<int>(marks);
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty!");
                }

                this.lastName = value;
            }
        }

        public string FN
        {
            get { return this.fN; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Faculty number cannot be null or empty!");
                }

                this.fN = value;
            }
        }

        public string Tel
        {
            get { return this.tel; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Tel. number cannot be null or empty!");
                }

                this.tel = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email cannot be null or empty!");
                }

                this.email = value;
            }
        }

        public List<int> Marks 
        {
            get { return this.marks; }
            private set
            {
                this.marks = value;
            }
        }

        public int GroupNumber 
        {
            get { return this.groupNumber; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Group number cannot be unpositive number!");
                }
                
                this.groupNumber = value;
            }
        }

        public string DepartmentName { get; set; }

    }
}
