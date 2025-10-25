using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    internal class BankAccount
    {
        #region Private
        private string ownerName;
        private double overdraftLimit;
        #endregion
        #region Public
        public int AccountNumber { get; private set; } //Read-only, set only by the constructor
        public string OwnerName
        {
            get
            {
                return ownerName;
            }
            set //Must be at least 3 characters
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Owner name must be at least 3 characters");
                }
                ownerName = value;
            }
        }
        public double Balance { get; private set; }
        public double OverdraftLimit { get { return overdraftLimit; } 
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Overdraft limit cannot be negative");
                }
                overdraftLimit = value;
            } 
        }
        public bool IsOverdrawn => Balance < 0; //read-only, '=>' is an "expression body," a short way to write a 'get' accessor
        public double AvailableFunds => Balance + OverdraftLimit;
        #endregion
        #region Constractor
        public BankAccount(int accountNumber, string ownerName, double inttialbalance = 0, double overdafterlimit = 0)
        {
            if (inttialbalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative");
            }
            this.AccountNumber = accountNumber;
            this.OwnerName = ownerName;
            Balance = inttialbalance;
            OverdraftLimit = overdafterlimit;
        }

        #endregion
        #region Methods
        //*behavior*
        public void Deposite(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive");
            }
            Balance += amount;
            Console.WriteLine($"Deposite {amount:C} New Balance {Balance:C}");
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be positive");
            }
            if (amount > AvailableFunds)
            {
                throw new InvalidOperationException("Insufficient funds. Withdrawal rejected");
            }
            Balance -= amount;
            Console.WriteLine($"Withdraw {amount:C} New Balance {Balance:C}");

        }
        #endregion
    }
}
