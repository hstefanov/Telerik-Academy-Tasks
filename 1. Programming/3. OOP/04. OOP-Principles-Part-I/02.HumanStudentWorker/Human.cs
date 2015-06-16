namespace HumanStudentWorker
{
    using System;

    public abstract class Human
    {
        private string firstName;

        private string lastName;

        public Human(string humanFirstName, string humanLastName)
        {
            this.FirstName = humanFirstName;
            this.lastName = humanLastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name is mandatory!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name is mandatory!");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
