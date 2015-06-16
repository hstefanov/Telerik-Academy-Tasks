namespace Animals
{
    using System;

    public class TomCat : Cat, ISound
    {
             public TomCat(int tomCatAge, string tomCatName, AnimalSex tomCatSex)
            : base(tomCatAge, tomCatName, tomCatSex)
        {
            if (tomCatSex != AnimalSex.male)
            {
                throw new ArgumentException("TomCat must be male");
            }
        }

        new public string ProduceSound()
        {
            return "TomCat Meow";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
