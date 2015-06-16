namespace Animals
{
    public class Cat : Animal , ISound
    {
         public Cat(int catAge, string catName, AnimalSex catSex)
            : base(catAge, catName, catSex)
        {
        }

        public string ProduceSound()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
