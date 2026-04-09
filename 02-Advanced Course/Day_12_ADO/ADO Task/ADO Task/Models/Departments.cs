using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Task.Models
{
    internal class Departments
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public List<Employees> Employees { get; set; }
    }
}
