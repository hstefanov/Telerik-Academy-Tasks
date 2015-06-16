namespace StudentTest
{
    using System;
    using System.Text;

    public enum Speciality
    {
        ComputerScience,
        Law,
        Medicine
    }

    public enum University
    {
        NewBulgarianUni,
        SoftUni,
        SofiaUni
    }

    public enum Faculty
    {
        FMI,
        MedicalFaculty,
        FacultyOfLaw
    }

    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int SSN { get; set; }

        public string PermanentAdress { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public Course Course { get; set; }

        public Speciality Speciality { get; set; }

        public University University { get; set; }

        public Faculty Faculty { get; set;}


        public Student(string StudentFirstName, string StudentMiddleName, string StudentLastName)
        {
            this.FirstName = StudentFirstName;
            this.MiddleName = StudentMiddleName;
            this.LastName = StudentLastName;
        }

        public Student(string StudentFirstName, string StudentMiddleName, string StudentLastName, Speciality StudentSpeciality, University StudentUniversity, Faculty StudentFaculty)
            : this(StudentFirstName, StudentMiddleName, StudentLastName)
        {
            this.Speciality = StudentSpeciality;
            this.University = StudentUniversity;
            this.Faculty = StudentFaculty;
        }

        public Student(string StudentFirstName, string StudentMiddleName, string StudentLastName, Speciality StudentSpeciality, University StudentUniversity, Faculty StudentFaculty, int StudentSSN, string StudentAdress, string StudentPhone, string StudentEmail, Course StudentCourse)
            : this(StudentFirstName, StudentMiddleName, StudentLastName, StudentSpeciality, StudentUniversity, StudentFaculty)
        {
            this.SSN = StudentSSN;
            this.PermanentAdress = StudentAdress;
            this.MobilePhone = StudentPhone;
            this.Email = StudentEmail;
            this.Course = StudentCourse;
        }

        public override bool Equals(object obj)
        {
            var student = obj as Student;
            if (student == null)
            {
                throw new ArgumentException("Passed object is not a Student");
            }

            // Social Security number (SSN) is a nine-digit number
            if (this.SSN == student.SSN)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return object.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !object.Equals(firstStudent, secondStudent);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            result.AppendLine(string.Format("{0}",this.SSN));
            result.AppendLine(string.Format("{0} {1} {2}", this.PermanentAdress, this.MobilePhone, this.Email));
            result.AppendLine(string.Format("{0} {1} {2}", this.University, this.Speciality, this.Faculty));
            result.AppendLine(string.Format("Attended Course : {0} , Id : {1}", this.Course.Name,this.Course.Id));
            return result.ToString();
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.MobilePhone.GetHashCode();
        }

        //2.Add implementations of the ICloneable interface. 
        //The Clone() method should deeply copy all object's fields into a new object of type Student.
        public object Clone()
        {
            var result = this.MemberwiseClone();
            (result as Student).Course = new Course(this.Course.Name, this.Course.Id);
            return result;
        }

        //3.Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order)
        //and by social security number (as second criteria, in increasing order).
        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
            {
                return string.Compare(this.FirstName, other.FirstName);
            }
            else if(this.SSN != other.SSN)
            {
                return (this.SSN - other.SSN);
            }
            return 0;
        }
    }
}
