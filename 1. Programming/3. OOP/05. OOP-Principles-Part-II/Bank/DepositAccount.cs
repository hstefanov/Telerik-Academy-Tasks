namespace Bank
{
    public class DepositAccount : Account, IDepositable, IDrawable
    {
        private const int DepositInterest = 1000;

        public DepositAccount(Customer depositCustomer, decimal depositBalance, decimal depositInterestRate)
            : base(depositCustomer, depositBalance, depositInterestRate)
        {

        }

        /// <summary>
        /// Deposit accounts have no interest if their balance is positive and less than 1000.
        /// </summary>
        
        public override decimal CalculateInterest(decimal numberOfmonths)
        {
            if (this.Balance >= DepositInterest)
            {
                return numberOfmonths * this.InterestRate * this.Balance;
            }
            else
            {
                return DefaultInterest;
            }
        }

        #region IDepositable Members

        public decimal DepositMoney(decimal amount)
        {
            return this.Balance = this.Balance + amount;
        }

        #endregion

        #region IDrawable Members

        public decimal WithDrawMoney(decimal amount)
        {
            return this.Balance = this.Balance - amount;
        }

        #endregion
    }
}
