using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class School
    {
        #region  property
        // This is the COMPOSITION relationship.
        public string Name { get; set; }
        // The School *has* an Address. The "private set", means no one outside the school can change its address.
        public Address SchoolAddress { get; private set; }

        private List<Department> departments; //backing field
        // "read-only" list. No one can .Add() or .Remove().
        public IReadOnlyList<Department> Departments => departments.AsReadOnly();
        // => : { get { return _departments.AsReadOnly(); } }
        #endregion
        #region Constractor
        public School(string name,string street,string city,string postalcode)
        {
            Name = name;
            // *COMPOSITION*, each school has an address object
            SchoolAddress = new Address(street, city, postalcode);
            departments = new List<Department>();
        }
        #endregion
        #region Methods
        public Department AddDepartment(string departmentname)
        {
            var department = new Department(departmentname);
            departments.Add(department);
            return department;
        }
        #endregion
    }
}
