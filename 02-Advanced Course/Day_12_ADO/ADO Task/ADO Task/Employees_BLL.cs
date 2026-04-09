using ADO_Task.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Task
{
    internal class Employees_BLL
    {
        public List<Employees> GetAllEmployees()
        {
            DAL dAL = new DAL();
            DataTable dataTable = dAL.GetAllEmployees();
            //Convert into list
            List<Employees> employees = new List<Employees>();
            foreach (DataRow row in dataTable.Rows)
            {
                employees.Add(new Employees
                {
                    ID = (int)row["ID"],
                    Name = row["Name"].ToString(),
                    Salary = (decimal)row["Salary"],
                    DeptID = (int)row["DeptID"]
                });
            }
            return employees;
        }
        public List<Employees> GetEmployeesByDept(int depID)
        {
            DAL dAL = new DAL();
            DataTable dataTable = dAL.GetEmployeesByDept(depID);
            //into list
            List<Employees> employeesByDept = new List<Employees>();
            foreach (DataRow row in dataTable.Rows)
            {
                var emp = new Employees
                {
                    ID = (int)row["ID"],
                    Name = row["Name"].ToString(),
                    Salary = (decimal)row["Salary"],
                    DeptID = (int)row["DeptID"]
                };
                employeesByDept.Add(emp);
            }
            return employeesByDept;
        }
    }
}
