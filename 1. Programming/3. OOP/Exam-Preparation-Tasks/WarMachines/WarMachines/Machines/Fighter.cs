namespace WarMachines.Machines
{
    using WarMachines.Interfaces;
    using System.Text;

    public class Fighter : Machine, IFighter
    {
        private const int InitialHealthPoints = 200;

        public Fighter(string initialName, double initialAttackPoints, double initialDefense,bool initialStealthMode)
            : base(initialName, InitialHealthPoints, initialAttackPoints, initialAttackPoints)
        {
            this.StealthMode = initialStealthMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(base.ToString());
            string StealthModeAsString = this.StealthMode ? ModeOn : ModeOff;
            result.Append(string.Format(" *Stealth: {0}", StealthModeAsString));

            return result.ToString();
        }
    }
}
