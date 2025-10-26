using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Person //"abstract" means you cannot create a "new Person()",It MUST be inherited by another class (like Teacher or Student).
    {
        #region Public property
        // A public property. Anyone can get or set.
        public string Name { get; set; }
        public int Age { get; set; }
        public string ContactDetails { get; set; }
        #endregion
        #region Constructor
        // "protected", meanS only this class or its children (Teacher, Student) can call it.
        protected Person(string name,int age,string contactdetails)
        {
            //the property = the parameter
            Name = name;
            Age = age;
            ContactDetails = contactdetails;
        }
        #endregion

    }
}
