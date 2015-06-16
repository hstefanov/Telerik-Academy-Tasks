namespace ShcoolTest
{
    using System.Collections.Generic;

    public class Teacher : Person, ICommentable
    {
        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.TeacherDisciplines = new List<Discipline>(disciplines);
            this.Comments = new List<string>();
        }

        public List<Discipline> TeacherDisciplines { get; set; }

        public List<string> Comments { get; set; }

        
        #region ICommentable Members

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }

        #endregion

        public void AddDiscipline(Discipline discipline)
        {
            this.TeacherDisciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.TeacherDisciplines.Remove(discipline);
        }

    }
}
