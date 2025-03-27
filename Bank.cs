using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Console___dotnet
{
    public class Bank
    {
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }

        public Bank(string name)
        {
            Name = name;
            Customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void RemoveCustomer(Customer customer)
        {
            Customers.Remove(customer);
        }

        public void GetCustomerDetails()
        {
            Console.WriteLine($"Bank: {Name}");
            foreach (var customer in Customers)
            {
                customer.GetAccountDetails();
                Console.WriteLine("====================");
            }
        }

        public bool TransferFunds(Account fromAccount, Account toAccount, decimal amount)
        {
            if (fromAccount.Withdraw(amount))
            {
                toAccount.Deposit(amount);
                return true;
            }
            return false;
        }
    }
}
