using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class
{
    internal class Employee
    {
        public int ID;
        public double Salary;
        public double Bonus;
        public double Deduction;
        public Identity identity { get; set; }


        public virtual double CalcNetSalary()
        {
            return Salary + Bonus - Deduction;
        }
        public override bool Equals(object? obj)
        {
            ////1
            if (obj is Employee employee)
            {
                return employee.ID == this.ID;
            }
            else
                return false;

            ////2
            /*Employee employee = obj as Employee;
            if (employee == null)
                return false;
            return employee.ID == this.ID;*/

            ////dont use this
            /*Employee employee = (Employee) obj;
            return employee.ID == this.ID;*/
            //return base.Equals(obj);
        }
        public override string ToString()
        {
            return $"ID {ID}";
            //return base.ToString();
        }
        public Employee DeepClone()
        {
            // 1. Shallow copy all value types and immutable strings
            var newEmp = this.MemberwiseClone() as Employee;

            // 2. Deep copy reference types, protecting against nulls
            if (this.identity != null)
            {
                newEmp.identity = new Identity
                {
                    key = this.identity.key,
                    pass = this.identity.pass
                };
            }

            return newEmp;

            //var newEmp = this.MemberwiseClone() as Employee;//value
            //newEmp.identity = new Identity
            //{
            //    key = this.identity.key,
            //    pass = this.identity.pass,
            //};//ref
            //return newEmp;

        }
        public Employee ShallowClone()
        {
            // 1. Shallow copy all value types and immutable strings
            return this.MemberwiseClone() as Employee;
        }
    }
}
