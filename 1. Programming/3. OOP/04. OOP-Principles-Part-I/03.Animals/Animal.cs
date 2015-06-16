namespace Animals
{
    public enum AnimalSex
    {
        male,
        female
    }

    public abstract class Animal
    {
        public Animal(int animalAge, string animalName, AnimalSex animalSex)
        {
            this.Age = animalAge;
            this.Name = animalName;
            this.AnimalSex = animalSex;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public AnimalSex AnimalSex { get; set; }

        public override string ToString()
        {
            return this.Age.ToString() + " " + this.Name + " " + this.AnimalSex;
        }
    }
}
