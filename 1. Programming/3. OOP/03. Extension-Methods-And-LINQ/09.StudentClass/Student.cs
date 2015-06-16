namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private string fn;
        private string email;
        private List<int> marks;
        private int groupNumber;
        private Group group;

        #region Constructors for problem 3 and 4
        public Student(string studentFirstName, string studentLastName)
        {
            this.FirstName = studentFirstName;
            this.LastName = studentLastName;
        }

        public Student(string studenFirstName, string studentLastName, int studentAge)
            : this(studenFirstName,studentLastName)
        {
            this.Age = studentAge;
        }
        #endregion

        public Student(string studentFirstName, string studentLastName, string studentFN, string studentPhoneNumber, string studentEmail, List<int> studentMarks, int studentGroupNumber)
            : this(studentFirstName, studentLastName)
        {
            this.FN = studentFN;
            this.phoneNumber = studentPhoneNumber;
            this.Email = studentEmail;
            this.Marks = studentMarks;
            this.GroupNumber = studentGroupNumber;
        }

        public Student(string studentFirstName, string studentLastName, string studentFN, string studentPhoneNumber, string studentEmail, List<int> studentMarks, int studentGroupNumber, Group studentGroup)
            : this(studentFirstName, studentLastName, studentFN, studentPhoneNumber, studentEmail, studentMarks, studentGroupNumber)
        {
            this.Group = studentGroup;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name can't be null, whitespace or empty!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name can't be null, whitespace or empty!");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be less than zero");
                }
                this.age = value;
            }
        }

        public string FN
        {
            get { return this.fn; }
            private set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FN can't be null, whitespace or empty!");
                }
                this.fn = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            private set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Email can't be null, whitespace or empty!");
                }
                this.email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                this.marks = value;
            }

        }
        public int GroupNumber
        {
            get { return this.groupNumber; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Group number can't be negative or zero!");
                }
                this.groupNumber = value;
            }
        }

        public string phoneNumber { get; private set; }

        public Group Group
        {
            get
            {
                return this.group;
            }
            set
            {
                if (value.GroupNumber <= 0)
                {
                    throw new ArgumentException("Group number must be larger than 0");
                }
                if (string.IsNullOrEmpty(value.DepartmentName))
                {
                    throw new ArgumentException("Department name cannot be null of empty");
                }
                this.group = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Name: {0} {1}", this.FirstName, this.LastName);
            result.AppendLine();
            if (this.FN != null && this.phoneNumber != null && this.Email != null && this.Marks != null && this.GroupNumber > 0)
            {
                result.AppendLine("FN: " + this.FN);
                result.AppendLine("PhoneNumber: " + this.phoneNumber);
                result.AppendLine("Email: " + this.Email);
                result.AppendLine("Marks: " + GetMarks());
                result.AppendLine("Group number: " + this.GroupNumber);
            }
            if (this.group != null)
            {
                result.AppendLine("Group Number : " + this.group.GroupNumber);
                result.Append("Department Name : " + this.group.DepartmentName);
            }
            return result.ToString();
        }

        public void AddMark(int mark)
        {
            if (mark >= 2 && mark <= 6)
            {
                this.marks.Add(mark);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid mark value! Mark value must be between 2 - 6!");
            }
        }

        public void RemoveMarkAt(int position)
        {
            if (position < 0 || position >= this.Marks.Count)
            {
                throw new IndexOutOfRangeException("Can't remove mark at position: " + position + " Index is out of range!");
            }

            this.marks.RemoveAt(position);
        }

        public bool ContainMark(int mark)
        {
            return this.marks.Contains(mark);
        }

        public string GetMarks()
        {
            return string.Join(", ", this.marks);
        }
    }
}
