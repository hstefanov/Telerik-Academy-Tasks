namespace Bank
{
    /// <summary>
    /// All accounts have customer, balance and interest rate (monthly based). 
    /// Deposit accounts are allowed to deposit and with draw money. 
    /// Loan and mortgage accounts can only deposit money.
    /// </summary>
    
    public abstract class Account
    {
        protected const int DefaultInterest = 0;

        public Account(Customer accountCustomer, decimal accountBalance, decimal accountInterestRate)
        {
            this.Customer = accountCustomer;
            this.Balance = accountBalance;
            this.InterestRate = accountInterestRate;
        }

        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }

        /// <summary>
        /// All accounts have customer, balance and interest rate (monthly based). 
        /// Deposit accounts are allowed to deposit and with draw money. 
        /// Loan and mortgage accounts can only deposit money.
        /// </summary>

        public virtual decimal CalculateInterest(decimal numberOfmonths)
        {
            return numberOfmonths * this.InterestRate * this.Balance;
        }
    }
}
