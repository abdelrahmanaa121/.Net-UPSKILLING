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
            // -------------------------------------------
            // TEST: BankAccount
            Console.WriteLine("=== Testing Assignment 1: BankAccount ===");
            //create a valid account
            Bankaccount myAccount = new Bankaccount("ACC-001", "Ahmed", 5000);
            Console.WriteLine($"Account Created for {myAccount.AccountHolderName} with Balance: {myAccount.Balance:C}");
            // try to manipulate Balance directly
            // myAccount.Balance = 1000000; 
            // test Deposit
            myAccount.Deposit(1500);
            // trying to withdraw more than exists
            Console.WriteLine("\nAttempting to withdraw 10,000...");
            myAccount.Withdraw(10000);
            // test Withdrawal
            Console.WriteLine("\nAttempting to withdraw 2,000...");
            myAccount.Withdraw(2000);

            // ==========================================
            // TEST 2: Product Inventory
            // ==========================================
            Console.WriteLine("\n\n=== Testing Assignment 2: Product Inventory ===");
            //create a product
            Product laptop = new Product("Gaming Laptop", 1200, 5);
            Console.WriteLine($"Product: {laptop.Name} | Price: {laptop.Price:C} | Stock: {laptop.StockQuantity}");
            Console.WriteLine($"Is Available? {laptop.IsAvailable}");
            //try setting negative price
            Console.WriteLine("\nAttempting to set price to -500...");
            laptop.Price = -500;
            Console.WriteLine($"Current Price remains: {laptop.Price:C}");
            //test Stock Logic
            Console.WriteLine("\nSelling 5 items (Stock goes to 0)...");
            laptop.AddStock(-5);
            Console.WriteLine($"New Stock: {laptop.StockQuantity} | Is Available? {laptop.IsAvailable}");

            // ==========================================
            // TEST 3: Car Class
            // ==========================================
            Console.WriteLine("\n\n=== Testing Assignment 3: Car Class ===");
            // 1. Create a car (Using a previous year to test Age)
            Car myCar = new Car("Toyota", "Corolla", 2015);
            // 2. Test Auto-Properties
            Console.WriteLine($"My Car: {myCar.Year} {myCar.Make} {myCar.Model}");
            // 3. Test Age Calculation (Dynamic property)
            Console.WriteLine($"Car Age: {myCar.Age} years old");
            // Note: If you run this in 2025, it will say 10 years old automatically.
            // 4. Test Drive Method (Modifying Mileage)
            Console.WriteLine($"Initial Mileage: {myCar.Mileage}");
            myCar.Drive(150);
            myCar.Drive(50);
            // 5. Try setting mileage directly (Uncommenting below would fail because setter is private)
            // myCar.Mileage = 0; 
            // Prevent console from closing immediately
            Console.ReadKey();
        }
    }
}
