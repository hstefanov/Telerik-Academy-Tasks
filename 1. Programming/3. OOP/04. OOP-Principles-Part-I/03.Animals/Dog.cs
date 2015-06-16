namespace Animals
{
    using System;
    public class Dog : Animal, ISound
    {
        public Dog(int dogAge, string dogName, AnimalSex dogSex)
            : base(dogAge, dogName, dogSex)
        {
        }

        #region ISound Members

        public string ProduceSound()
        {
            return "Bark, bark!";
        }

        #endregion

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
