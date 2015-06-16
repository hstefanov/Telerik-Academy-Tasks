namespace Animals
{
    public class Frog : Animal, ISound
    {
        public Frog(int frogAge, string frogName, AnimalSex frogSex)
            : base(frogAge, frogName, frogSex)
        {

        }

        #region ISound Members

        public string ProduceSound()
        {
            return "Quaq!";
        }

        #endregion

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
