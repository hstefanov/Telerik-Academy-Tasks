namespace HumanStudentWorker
{
    public class Worker : Human
    {
        public Worker(string workerFirstName, string workerLastName, double salary, double hoursPerDay)
            : base(workerFirstName, workerLastName)
        {
            this.WeekSalary = salary;
            this.WorkHoursPerDay = hoursPerDay;
        }

        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            return WeekSalary / (WorkHoursPerDay * 5.0);
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.WeekSalary + " " + this.WorkHoursPerDay;
        }
    }
}
