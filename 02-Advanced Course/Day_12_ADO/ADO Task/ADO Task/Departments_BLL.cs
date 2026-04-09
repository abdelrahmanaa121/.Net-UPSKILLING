using ADO_Task.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Task
{
    internal class Departments_BLL
    {
        public List<Departments> GetAllDepartments(bool includeEmployee = false)
        {
            DAL dAL = new DAL();
            DataTable dataTable = dAL.GetAllDepartments();
            List<Departments> GetAllDepartments = new List<Departments>();
            foreach (DataRow row in dataTable.Rows)
            {
                var dept = new Departments
                {
                    DeptID = (int)row["DeptID"],
                    DeptName = row["DeptName"].ToString()
                };
                GetAllDepartments.Add(dept);
                if (includeEmployee)
                {
                    var Emp = new Employees_BLL();
                    dept.Employees = Emp.GetEmployeesByDept(dept.DeptID);
                }
            }
            return GetAllDepartments;
        }
    }
}
