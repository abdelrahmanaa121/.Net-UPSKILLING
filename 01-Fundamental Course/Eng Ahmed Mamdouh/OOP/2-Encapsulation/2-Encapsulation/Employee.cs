using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Encapsulation
{
    internal class Employee
    {
        public int id;
        public string name;
        //Backfield
        private double _salary;
        public double Salary
        {
            get
            {
                return _salary;
            }
            set 
            {
                if (value >= 5000)
                {
                    _salary = value;
                }
                else
                {
                    _salary = 5000;
                }
            }
        }
        public void Test()
        {
            Salary = 7000;
        }
        //private double Salary;
        //public void SetSalary(double salary)
        //{
        //    if (salary >= 5000)
        //    {
        //        Salary = salary;
        //    }
        //    else
        //    {
        //        Salary = 5000;
        //    }
        //}
        //public double GetSalary()
        //{
        //    return Salary;
        //}
    }
}
