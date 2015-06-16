/*
A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
Customers could be individuals or companies.
*/

namespace Bank
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;

    class BankTest
    {
        static void PrintAccounts(IEnumerable<Account> accounts)
        {
            foreach (var account in accounts)
            {
                Console.WriteLine(string.Format("I am {0} and i am owned by {1},\n my current balance is {2} and the interest rate for {3} months is: {4:F2}",account.GetType(),account.Customer.GetType(),account.Balance,3,account.CalculateInterest(3)));
                Console.WriteLine(new string('-',50));
            }
        }

        /// <summary>
        /// Your task is to write a program to model the bank system by classes and interfaces. 
        /// You should identify the classes, interfaces, base classes and abstract actions and implement the calculation 
        /// of the interest functionality through overridden methods.
        /// </summary>
        
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            DepositAccount depositAccountIndividual = new DepositAccount(new Individual("Hristo Stefanov", 2600), 4000m, 0.02m);
            DepositAccount depositAccountCompany = new DepositAccount(new Company("Telerik", 2), 10000000m, 1.5m);

            LoanAccount loanAccountIndividual = new LoanAccount(new Individual("Stoqn Matev", 500), 2000m, 0.001m);
            LoanAccount loanAccountCompany = new LoanAccount(new Company("Google", 10), 3232323232m, 10.4m);

            MortgageAccount mortgageAccountIndividual = new MortgageAccount(new Individual("Dobrin Rusev", 400), 3000m, 0.03m);
            MortgageAccount mortgageAccountCompany = new MortgageAccount(new Company("vmWare", 323), 9999999m, 10.1m);

            var accounts = new List<Account>()
            {
                depositAccountIndividual,
                depositAccountCompany,
                loanAccountIndividual,
                loanAccountCompany,
                mortgageAccountIndividual,
                mortgageAccountCompany
            };

            PrintAccounts(accounts);

            depositAccountIndividual.DepositMoney(1000m);
            depositAccountIndividual.WithDrawMoney(130m);

            Console.WriteLine("Deposit account owned by Individual :\nMy current balance is:{0}, and my interest for 2 months is: {1:F2}",depositAccountIndividual.Balance,depositAccountIndividual.InterestRate);

        }
    }
}
