using Simple_Bank_Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankAccount
            Console.WriteLine("BankAccount");
            Bankaccount myAccount = new Bankaccount("AC001", "Ahmed", 5000);
            Console.WriteLine($"Account Created for {myAccount.AccountHolderName} with Balance: {myAccount.Balance:C}");
            myAccount.Deposit(1500);
            Console.WriteLine("withdraw 10,000");
            myAccount.Withdraw(10000);
            Console.WriteLine("withdraw 2,000");
            myAccount.Withdraw(2000);

            //Product Inventory
            Console.WriteLine("Product Inventory");
            Product laptop = new Product("Gaming Laptop", 1200, 5);
            Console.WriteLine($"Product: {laptop.Name} | Price: {laptop.Price:C} | Stock: {laptop.StockQuantity}");
            Console.WriteLine($"Is Available? {laptop.IsAvailable}");
            Console.WriteLine("set price to -500");
            laptop.Price = -500;
            Console.WriteLine($"Current Price remains: {laptop.Price:C}");
            Console.WriteLine("Selling 5 items (Stock goes to 0)");
            laptop.AddStock(-5);
            Console.WriteLine($"New Stock: {laptop.StockQuantity} | Is Available? {laptop.IsAvailable}");

            //Car Class
            Console.WriteLine("Car Class");
            Car myCar = new Car("Toyota", "Corolla", 2015);
            Console.WriteLine($"My Car: {myCar.Year} {myCar.Make} {myCar.Model}");
            Console.WriteLine($"Car Age: {myCar.Age} years old");
            Console.WriteLine($"Initial Mileage: {myCar.Mileage}");
            myCar.Drive(150);
            myCar.Drive(50);
        }
    }
}
