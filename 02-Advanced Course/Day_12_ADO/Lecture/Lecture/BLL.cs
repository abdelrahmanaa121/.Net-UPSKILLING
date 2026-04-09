using Lecture.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    internal class BLL
    {
        public List<Employee> GetEmployees()
        {
            DAL dAL = new DAL();
            DataTable dataTable = dAL.GetEmployees();
            //convert into list
            List<Employee> employees = new List<Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                employees.Add(new Employee
                {
                    ID = (int)row["Id"],
                    Name = row["Name"].ToString(),
                    Salary = (double)row["Salary"]

                });
            }
            return employees;
        }
        public List<Employee> GetEmployeesByDepID(int depID)
        {
            DAL dAL = new DAL();
            DataTable dataTable = dAL.GetEmployeesByDepID(depID);
            //convert into lisr
            List<Employee> employeesByDepID = new List<Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
                employeesByDepID.Add(new Employee
                {
                    ID = (int)row["Id"],
                    Name = row["Name"].ToString(),
                    Salary = (double)row["Salary"]
                });
            }
            return employeesByDepID;
        }
        public List<Department> GetDepartments(bool includeEmp = false)
        {
            DAL dAL = new DAL();
            DataTable dataTable = dAL.GetDepartments();
            //convert into list
            List<Department> departments = new List<Department>();
            foreach (DataRow row in dataTable.Rows)
            {
                var dept = new Department
                {
                    Dep_Id = (int)row["Id"],
                    Dep_Name = row["Name"].ToString(),
                };
                //departments.Add(new Department
                //{
                //    Dep_Id = (int)row["Id"],
                //    Dep_Name = row["Name"].ToString(),
                //});
                departments.Add(dept);
                //لا يفضل اجيب الموظفين مع الاقسام بالطريقة ديه لان ده هيديك ع البيرفومنس 
                //dept.Employees = GetEmployeesByDepID(dept.Dep_Id);
                //فهضيف الشرط لو عايز الموظفين
                if (includeEmp =true)
                {
                    dept.Employees = GetEmployeesByDepID(dept.Dep_Id);
                }
            }
            return departments;
        }
    }
}
