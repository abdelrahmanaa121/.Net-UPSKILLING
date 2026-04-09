using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Models
{
    internal class Department
    {
        public int Dep_Id { get; set; }
        public string Dep_Name { get; set; }
        public List<Employee> Employees { get; set; }

    }
}
