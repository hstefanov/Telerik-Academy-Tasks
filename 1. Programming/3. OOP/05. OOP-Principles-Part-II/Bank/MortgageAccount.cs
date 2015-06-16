namespace Bank
{
    public class MortgageAccount : Account, IDepositable
    {
        private const int IndividualInterest = 6;
        private const int CompanyInterest = 12;

        public MortgageAccount(Customer morrtgageCustomer, decimal mortgageBalance, decimal mortgageInterestRate)
            : base(morrtgageCustomer, mortgageBalance, mortgageInterestRate)
        {

        }

        /// <summary>
        /// Mortgage accounts have ½ interest for the first 12 months for companies 
        /// and no interest for the first 6 months for individuals.
        /// </summary>
        
        public override decimal CalculateInterest(decimal numberOfmonths)
        {
            if ((numberOfmonths <= IndividualInterest && this.Customer is Individual))
            {
                return 0;
            }
            else if (numberOfmonths <= CompanyInterest && this.Customer is Company)
            {
                return base.CalculateInterest(numberOfmonths) / 2;
            }
            else
            {
                return base.CalculateInterest(numberOfmonths);
            }
        }

        public decimal DepositMoney(decimal amount)
        {
            return this.Balance = this.Balance + amount;
        }

        public override string ToString()
        {
            return this.Customer.Name;
        }
    }
}
