using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Bank_Account
{
    internal class Product
    {
        // Backing field
        private double _Price;
        private int _StockQuantity;
        //prop
        public string Name { get; set; }
        public double Price 
        { get { return _Price; }
            set 
            {
                if (value < 0 )
                {
                    Console.WriteLine("Price cannot be negative");
                }
                else
                {
                    _Price = value;
                }
            }
        }
        public int StockQuantity 
        { get {return _StockQuantity; } 
            set 
            {
                if (value < 0)
                    {
                        Console.WriteLine("Stock Quantity cannot be negative");
                    }
                    else
                    {
                        _StockQuantity = value;
                    }
            }
        }
        public bool IsAvailable
        {
            get { return StockQuantity > 0; }
        }
        // Constructor
        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            StockQuantity = stock; 
        }
        //method
        public void AddStock(int amount)
        {
            if (StockQuantity+amount<0)
            {
                Console.WriteLine("Can not remove stock more than available");
            }
            else
            {
                StockQuantity += amount;
                Console.WriteLine($"Stock Updated, new stock {StockQuantity}, Available{IsAvailable}");
            }
        }
    }
}
