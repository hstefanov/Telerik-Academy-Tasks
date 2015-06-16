namespace ShcoolTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Class : ICommentable
    {
        private string classesId;

        public Class(List<Student> classStudents,List<Teacher> classTeaches,string classId)
        {
            this.students = new List<Student>(classStudents);
            this.teachers = new List<Teacher>(classTeaches);
            this.ClassesId = classId;
            this.Comments = new List<string>();
        }

        public string ClassesId
        {
            get
            {
                return this.classesId;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Classes should have unique text identifier!");
                }
                this.classesId = value;
            }
        }

        public List<Student> students;

        public List<Teacher> teachers;

        //Methods
        /// <summary>
        /// Add new student to the class
        /// </summary>
        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        /// <summary>
        /// Remove a student from the class
        /// </summary>
        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        /// <summary>
        /// Add new Teacher to the class
        /// </summary>
        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        /// <summary>
        /// Remove a teacher from the class
        /// </summary>
        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }


        #region ICommentable Members

        public List<string> Comments { get; set; }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }

        #endregion

        StringBuilder info = new StringBuilder();

        public override string ToString()
        {
            info.AppendLine(string.Format("Information for {0} class", this.classesId));
            info.AppendLine("Teachers :");
            foreach (var teacher in this.teachers)
            {
                info.AppendLine((teacher.Name));
            }

            info.AppendLine("Students :");

            foreach (var student in this.students)
            {
                info.AppendLine(student.Name);
            }


            if (this.Comments != null)
            {
                info.AppendLine(string.Format("Additional information : "));
                foreach (var comment in Comments)
                {
                    info.AppendLine(comment);
                }
            }

            return info.ToString();
        }
    }
}
