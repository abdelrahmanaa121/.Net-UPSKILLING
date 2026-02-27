using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Bank_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            try
            {
                BankAccount AliceAccount = new BankAccount(12345, "Alice", 0, 2500);
                Customer Alice = new Customer(1, "Alice");
                Alice.PrimaryAccount = AliceAccount;
                Console.WriteLine($"Created account for {Alice.Name} with limit {AliceAccount.OverdraftLimit:C}");
                AliceAccount.Deposite(10000);
                Console.WriteLine($"");
                AliceAccount.Withdraw(12000);
                //print
                Console.WriteLine("Account Statues");
                Console.WriteLine($"Customer Name: {Alice.Name}");
                Console.WriteLine($"Account Number: {AliceAccount.AccountNumber}");
                Console.WriteLine($"Balance: {AliceAccount.Balance:C}");
                Console.WriteLine($"Overdraft Limit: {AliceAccount.OverdraftLimit:C}");
                Console.WriteLine($"Is Overdrawn: {AliceAccount.IsOverdrawn}");
                Console.WriteLine($"Available Funds: {AliceAccount.AvailableFunds:C}");
                Console.WriteLine($"Customer Can Withdraw: {Alice.CanWithdraw}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n--- OPERATION FAILED ---");
                Console.WriteLine($"Error: {ex.Message}");
            }

            
        }
    }
}
