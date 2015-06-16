namespace ShcoolTest
{
    using System;
    using System.Collections.Generic;

    public class Discipline : ICommentable
    {
        private string name;
        private int lecturesCount;
        private int exercisesCount;

        public Discipline(string disciplineName, int disciplineLecturesCount, int disciplineExcerciseCount)
        {
            this.Name = disciplineName;
            this.lecturesCount = disciplineLecturesCount;
            this.Comments = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Discipline should have name!");
                }
                this.name = value;
            }
        }

        public int LecturesCount
        {
            get
            {
                return this.lecturesCount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Lectures count should be positive number!");
                }
                this.lecturesCount = value;
            }
        }

        public int ExerciseCount
        {
            get
            {
                return this.exercisesCount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Excercise count should be positive number!");
                }
                this.exercisesCount = value;
            }
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
