namespace Bank
{
    using System;

    /// <summary>
    /// All accounts have customer, balance and interest rate (monthly based). 
    /// Deposit accounts are allowed to deposit and with draw money. 
    /// Loan and mortgage accounts can only deposit money.
    /// </summary>
    
    public abstract class Customer
    {
        private string name;
        private int idCustomer;

        protected Customer(string personName,int personId)
        {
            this.Name = personName;
            this.CustomerID = personId;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name is mandatory!");
                }
                this.name = value;
            }
        }

        public int CustomerID
        {
            get
            {
                return this.idCustomer;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Each customer/company should be positive number!");
                }
                this.idCustomer = value;
            }
        }
    }
}
