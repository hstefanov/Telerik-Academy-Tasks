namespace Bank
{
    public class LoanAccount : Account, IDepositable
    {
        private const int IndividualInterest = 3;
        private const int CompanyInterest = 2;

        public LoanAccount(Customer loadAccountCustomer, decimal loanAccountBalance, decimal loanAccountInterestRate)
            : base(loadAccountCustomer, loanAccountBalance, loanAccountInterestRate)
        {

        }

        /// <summary>
        /// Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months 
        /// if are held by a company.
        /// </summary>
        
        public override decimal CalculateInterest(decimal numberOfmonths)
        {
            if ((this.Customer is Individual) && (numberOfmonths > IndividualInterest))
            {
                return (numberOfmonths - 3) * this.InterestRate * this.Balance;
            }
            else if ((this.Customer is Company) && (numberOfmonths > CompanyInterest))
            {
                return (numberOfmonths - 2) * this.InterestRate * this.Balance;
            }
            else
            {
                return DefaultInterest;
            }
        }

        public decimal DepositMoney(decimal amount)
        {
            return this.Balance = this.Balance + amount;
        }

        public override string ToString()
        {
            return "LoanAccount";
        }
    }
}
