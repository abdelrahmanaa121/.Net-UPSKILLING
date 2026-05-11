using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class
{
    internal class Manager : Employee
    {
        public override double CalcNetSalary()
        {
            var salary = base.CalcNetSalary();
            return salary + (0.25 * salary);
        }
    }
}
