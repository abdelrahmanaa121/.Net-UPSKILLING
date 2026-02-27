using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public void CLK_IN()
        {

        }
        public override bool Equals(object obj)
        {
            //1-using casting
            //Employee e = (Employee)obj;
            //return this.ID == e.ID;

            //2-using as operator (best practise)
            Employee emp = obj as Employee;
            if (emp != null)
            {
                return this.ID == emp.ID;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            //return base.ToString();
            return $"Employee ID {ID},Name {Name}";
        }
        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return this.ID * 1000;
        }
    }
}
