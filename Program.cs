using Bank_Console___dotnet;

public class Program
{
    private static Bank bank = new Bank("MyBank");

    public static void Main()
    {
        while (true)
        {
            DisplayMainMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateCustomer();
                    break;
                case "2":
                    CreateAccount();
                    break;
                case "3":
                    DepositFunds();
                    break;
                case "4":
                    WithdrawFunds();
                    break;
                case "5":
                    TransferFunds();
                    break;
                case "6":
                    ViewCustomerDetails();
                    break;
                case "7":
                    Console.WriteLine("Exiting the system. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    private static void DisplayMainMenu()
    {
        Console.WriteLine("===== Banking System Menu =====");
        Console.WriteLine("1. Create a Customer");
        Console.WriteLine("2. Create an Account");
        Console.WriteLine("3. Deposit Funds");
        Console.WriteLine("4. Withdraw Funds");
        Console.WriteLine("5. Transfer Funds");
        Console.WriteLine("6. View Customer Details");
        Console.WriteLine("7. Exit");
        Console.Write("Enter your choice: ");
    }

    private static void CreateCustomer()
    {
        Console.Write("Enter Customer ID: ");
        int customerID = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Customer newCustomer = new Customer(customerID, name, email);
        bank.AddCustomer(newCustomer);
        Console.WriteLine("Customer created successfully!");
    }

    private static void CreateAccount()
    {
        Console.Write("Enter Customer ID: ");
        int customerID = int.Parse(Console.ReadLine());

        Customer customer = bank.Customers.FirstOrDefault(c => c.CustomerID == customerID);
        if (customer == null)
        {
            Console.WriteLine("Customer not found.");
            return;
        }

        Console.Write("Enter Account Number: ");
        string accountNumber = Console.ReadLine();

        Console.WriteLine("Select Account Type:");
        Console.WriteLine("1. Savings Account");
        Console.WriteLine("2. Checking Account");
        string accountTypeChoice = Console.ReadLine();

        Account newAccount;
        switch (accountTypeChoice)
        {
            case "1":
                newAccount = new SavingsAccount(accountNumber, customerID, 2.5);
                break;
            case "2":
                newAccount = new CheckingAccount(accountNumber, customerID, 500);
                break;
            default:
                Console.WriteLine("Invalid account type.");
                return;
        }

        customer.AddAccount(newAccount);
        Console.WriteLine("Account created successfully!");
    }

    private static void DepositFunds()
    {
        Console.Write("Enter Account Number: ");
        string accountNumber = Console.ReadLine();

        Account account = FindAccount(accountNumber);
        if (account == null) return;

        Console.Write("Enter Amount to Deposit: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        try
        {
            account.Deposit(amount);
            Console.WriteLine("Deposit successful!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Deposit failed: {ex.Message}");
        }
    }

    private static void WithdrawFunds()
    {
        Console.Write("Enter Account Number: ");
        string accountNumber = Console.ReadLine();

        Account account = FindAccount(accountNumber);
        if (account == null) return;

        Console.Write("Enter Amount to Withdraw (or percentage with % at end): ");
        string withdrawalInput = Console.ReadLine();

        try
        {
            if (withdrawalInput.EndsWith("%"))
            {
                double percentage = double.Parse(withdrawalInput.TrimEnd('%'));
                account.Withdraw(percentage);
            }
            else
            {
                decimal amount = decimal.Parse(withdrawalInput);
                account.Withdraw(amount);
            }
            Console.WriteLine("Withdrawal successful!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Withdrawal failed: {ex.Message}");
        }
    }

    private static void TransferFunds()
    {
        Console.Write("Enter Source Account Number: ");
        string sourceAccountNumber = Console.ReadLine();

        Account fromAccount = FindAccount(sourceAccountNumber);
        if (fromAccount == null) return;

        Console.Write("Enter Destination Account Number: ");
        string destAccountNumber = Console.ReadLine();

        Account toAccount = FindAccount(destAccountNumber);
        if (toAccount == null) return;

        Console.Write("Enter Amount to Transfer: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        if (bank.TransferFunds(fromAccount, toAccount, amount))
        {
            Console.WriteLine("Transfer successful!");
        }
        else
        {
            Console.WriteLine("Transfer failed.");
        }
    }

    private static void ViewCustomerDetails()
    {
        Console.Write("Enter Customer ID: ");
        int customerID = int.Parse(Console.ReadLine());

        Customer customer = bank.Customers.FirstOrDefault(c => c.CustomerID == customerID);
        if (customer == null)
        {
            Console.WriteLine("Customer not found.");
            return;
        }

        customer.GetAccountDetails();
    }

    private static Account FindAccount(string accountNumber)
    {
        foreach (var customer in bank.Customers)
        {
            var account = customer.Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account != null)
            {
                return account;
            }
        }

        Console.WriteLine("Account not found.");
        return null;
    }
}