namespace Animals
{
    using System;

    public class Kitten : Cat, ISound
    {
        public Kitten(int kittenAge, string kittenName, AnimalSex kittenSex)
            : base(kittenAge, kittenName, kittenSex)
        {
            if (kittenSex != AnimalSex.female)
            {
                throw new ArgumentException("Kittens must be female");
            }
        }

        new public string ProduceSound()
        {
            return "Kitten Meow";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
