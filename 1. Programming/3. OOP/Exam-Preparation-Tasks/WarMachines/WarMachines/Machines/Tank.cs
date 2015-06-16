namespace WarMachines.Machines
{
    using WarMachines.Interfaces;
    using System.Text;

    public class Tank : Machine, ITank, IMachine
    {
        private const int InitialHealthPoints = 100;
        private const int AttackPointsModifier = 40;
        private const int DefensePointsModifier = 30;

        public Tank(string initialName, double initialAttackPoints, double initialDefense)
            : base(initialName, InitialHealthPoints, initialAttackPoints, initialAttackPoints)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                
                this.AttackPoints += AttackPointsModifier;
                this.DefensePoints -= DefensePointsModifier;
            }
            else
            {
                this.AttackPoints -= AttackPointsModifier;
                this.DefensePoints += DefensePointsModifier;
            }
            this.DefenseMode = !this.DefenseMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(base.ToString());
            string defenseModeAsString = this.DefenseMode ? ModeOn : ModeOff;
            result.Append(string.Format(" *Defense: {0}",defenseModeAsString));

            return result.ToString();
        }
    }
}
