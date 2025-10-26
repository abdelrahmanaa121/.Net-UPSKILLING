using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class University
    {
        #region Public property
        public string Name { get; set; }
        public List<School> Schools { get; set; }
        #endregion
        #region Constractor
        public University(string name)
        {
            Name = name;
            Schools = new List<School>();
        }
        #endregion
        #region Methods
        public void AddSchool(School school)
        {
            if (!Schools.Contains(school))
            {
                Schools.Add(school);
            }
        }
        #endregion
    }
}
