namespace StudentClass
{
    public class Group
    {
        public Group(int groupNumer, string departmentName)
        {
            this.GroupNumber = groupNumer;
            this.DepartmentName = departmentName;
        }

        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }
    }
}
