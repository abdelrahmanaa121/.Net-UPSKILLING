using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    internal class Customer
    {
        #region Private
        private string name;
        #endregion
        #region Prop
        public int ID { get; set; }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length<3)
                {
                    throw new ArgumentException("Customer name must be at least 3 characters");
                }
                name = value;
            }
        }
        public BankAccount PrimaryAccount { get; set; }
        public bool CanWithdraw => PrimaryAccount != null && PrimaryAccount.AvailableFunds > 0;
        #endregion
        #region Constractor
        public Customer(int id,string name)
        {
            ID = id;
            Name = name;
        }
        #endregion
        #region Methods

        #endregion
    }
}
