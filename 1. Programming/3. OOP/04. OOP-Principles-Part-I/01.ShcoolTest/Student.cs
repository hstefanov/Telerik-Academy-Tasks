namespace ShcoolTest
{
    using System.Collections.Generic;

    public class Student : Person, ICommentable
    {
        public int UniqueNumber { get; set; }

        public Student(string studentName, int studentUniqueNumber)
            : base(studentName)
        {
            this.UniqueNumber = studentUniqueNumber;
            this.Comments = new List<string>();
        }

        #region ICommentable Members

        public List<string> Comments { get; set; }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }

        #endregion
    }
}
