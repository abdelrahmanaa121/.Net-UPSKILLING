using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Address
    {
        #region Public property
        public string Street { get; set; }
        public string City { get; set; }

        public string PostalCode { get; set; }


        #endregion
        #region Constractor
        public Address(string street,string city,string postalcode)
        {
            Street = street;
            City = city;
            PostalCode = postalcode;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"{Street},{City},{PostalCode}";
        }
        #endregion
    }
}
