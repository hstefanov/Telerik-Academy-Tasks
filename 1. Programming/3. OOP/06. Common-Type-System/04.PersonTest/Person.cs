namespace PersonTest
{
    public class Person
    {
        public Person(string name, byte? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public byte? Age { get; set; }

        public override string ToString()
        {
            return string.Format("Name of the person : {0,2} Age : {1,3}", this.Name, ((this.Age != null) ? this.Age.ToString() : "Not Specified"));
        }
    }
}
