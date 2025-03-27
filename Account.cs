using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Console___dotnet
{
    public abstract class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public int CustomerID { get; set; }
        public List<Transaction> Transactions { get; set; }

        public Account(string accountNumber, int customerID)
        {
            AccountNumber = accountNumber;
            CustomerID = customerID;
            Balance = 0;
            Transactions = new List<Transaction>();
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            Balance += amount;
            Transactions.Add(new Transaction(Transactions.Count + 1, AccountNumber, amount, "Deposit"));
        }

        public virtual bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (Balance < amount)
            {
                Console.WriteLine("Insufficient funds.");
                return false;
            }
            Balance -= amount;
            Transactions.Add(new Transaction(Transactions.Count + 1, AccountNumber, amount, "Withdrawal"));
            return true;
        }

        public virtual bool Withdraw(double percentage)
        {
            if (percentage <= 0 || percentage > 100)
            {
                throw new ArgumentException("Percentage must be between 0 and 100.");
            }
            decimal withdrawalAmount = Balance * (decimal)(percentage / 100);
            return Withdraw(withdrawalAmount);
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }



}
