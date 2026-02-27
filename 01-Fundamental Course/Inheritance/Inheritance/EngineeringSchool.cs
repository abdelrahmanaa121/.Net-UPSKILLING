using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class EngineeringSchool : School
    {
        #region Public property

        #endregion
        #region Constractor
        public EngineeringSchool(string street, string city, string postalcode) : base("School of Engineering", street, city, postalcode)
        {
            //no need
        }
        #endregion
        #region Methods

        #endregion
    }
}

