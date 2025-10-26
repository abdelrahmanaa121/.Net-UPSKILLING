using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Department
    {
        #region Public property
        public string Name { get; set; }
        // This is the AGGREGATION relationship, The Department "has" teachers, but does not "own" them.
        public List<Teacher> Teachers { get; private set; }

        #endregion
        #region Constractor
        // "internal" means only classes in the same project can call this.
        // This *enforces* Composition. It stops anyone from creating a "rogue" Department. It must be created by the School.
        internal Department(string name)
        {
            Name = name;
            Teachers = new List<Teacher>();

        }
        #endregion
        #region Methods
        public void AddTeacher(Teacher teacher)
        {
            if (!Teachers.Contains(teacher))
            {
                Teachers.Add(teacher);
            }
        }
        #endregion
    }
}
