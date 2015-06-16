namespace StudentTest
{
    public class Course
    {
        public Course(string courseName, int courseId)
        {
            this.Name = courseName;
            this.Id = courseId;
        }

        public string  Name { get; set; }

        public int Id { get; set; }
    }
}
