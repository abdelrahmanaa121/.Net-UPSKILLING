using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Bank_Account
{
    internal class Bankaccount
    {
        public string AccountNumber { get; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; private set; }
        //constractor
        public Bankaccount(string accountnumber ,string accountholdername, decimal intbalance)
        {
            AccountNumber = accountnumber;
            AccountHolderName = accountholdername;
            if(intbalance < 0)
            {
                Console.WriteLine("Initial balance cannot be negative! Setting to 0");
                intbalance = 0;
            }
            else
            {
                Balance = intbalance;
            }
        }
        //methods
        public void Deposit(decimal deposit)
        {
            if(deposit <= 0)
            {
                Console.WriteLine("Deposit amount must be positive");
                return;
            }
            Balance += deposit;
            Console.WriteLine($"Deposited: {deposit:C} and new Balance = {Balance:C}");
        }
        public void Withdraw(decimal withdraw)
        {
            if(withdraw <=0)
            {
                Console.WriteLine("Withdraw amount must be positive");
                return;
            }
            if (withdraw > Balance)
            {
                Console.WriteLine("Can not Withdraw");
                return;
            }
            Balance -= withdraw;
            Console.WriteLine($"Withdraw: {withdraw:C} and new Balance = {Balance:C}");
        }
    }
}
