using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Console___dotnet
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
        public DateTime Date { get; set; }

        public Transaction(int transactionId, string accountNumber, decimal amount, string transactionType)
        {
            TransactionID = transactionId;
            AccountNumber = accountNumber;
            Amount = amount;
            TransactionType = transactionType;
            Date = DateTime.Now;
        }

        public void GetTransactionDetails()
        {
            Console.WriteLine($"Transaction ID: {TransactionID}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Amount: {Amount:C}");
            Console.WriteLine($"Type: {TransactionType}");
            Console.WriteLine($"Date: {Date}");
        }
    }

}
