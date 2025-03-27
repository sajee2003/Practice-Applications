using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Console___dotnet
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string accountNumber, int customerID, double interestRate)
            : base(accountNumber, customerID)
        {
            InterestRate = interestRate;
        }

        public void ApplyInterest()
        {
            decimal interest = Balance * (decimal)(InterestRate / 100);
            Deposit(interest);
        }
    }
}
