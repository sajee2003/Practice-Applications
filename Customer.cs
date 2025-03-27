using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Console___dotnet
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Account> Accounts { get; set; }

        public Customer(int customerID, string name, string email)
        {
            CustomerID = customerID;
            Name = name;
            Email = email;
            Accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            Accounts.Remove(account);
        }

        public void GetAccountDetails()
        {
            Console.WriteLine($"Customer: {Name} (ID: {CustomerID})");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine("Accounts:");
            foreach (var account in Accounts)
            {
                Console.WriteLine($"Account Number: {account.AccountNumber}");
                Console.WriteLine($"Balance: {account.GetBalance():C}");
                Console.WriteLine("---");
            }
        }
    }
}
