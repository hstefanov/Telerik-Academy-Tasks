namespace HumanStudentWorker
{
    public class Student : Human
    {
        public Student(string studentFirstName, string studentLastName, int studentGrade)
            : base(studentFirstName, studentLastName)
        {
            this.Grade = studentGrade;
        }

        public int Grade { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.Grade;
        }
    }
}
