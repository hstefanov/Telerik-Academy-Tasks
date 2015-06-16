namespace ShcoolTest
{
    using System;

    public abstract class Person
    {
        private string name;

        public Person(string personName)
        {
            this.Name = personName;
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
                    throw new ArgumentException("Name is mandatory!");
                }
                this.name = value;
            }
        }
    }
}
