using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Console___dotnet
{
    public class CheckingAccount : Account
    {
        public decimal OverdraftLimit { get; set; }

        public CheckingAccount(string accountNumber, int customerID, decimal overdraftLimit)
            : base(accountNumber, customerID)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override bool Withdraw(decimal amount)
        {
            if (Balance + OverdraftLimit >= amount)
            {
                Balance -= amount;
                Transactions.Add(new Transaction(Transactions.Count + 1, AccountNumber, amount, "Withdrawal"));
                return true;
            }
            Console.WriteLine("Insufficient funds, including overdraft limit.");
            return false;
        }
    }
}
