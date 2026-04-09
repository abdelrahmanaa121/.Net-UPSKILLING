using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Task
{
    internal class DAL
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data source=.; initial catalog=CompanyDB; integrated security=true; TrustServerCertificate=true");
        SqlDataAdapter adapter = new SqlDataAdapter();
        public DataTable GetAllDepartments()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "select * from Departments";
            adapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetAllEmployees()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "select * from Employees";
            adapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetEmployeesByDept(int deptID)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "select * from Employees where DeptID = @deptID";
            sqlCommand.Parameters.AddWithValue("@deptID", deptID);
            adapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public void InsertEmployee(string name, decimal salary,int deptId)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "insert into Employees (Name, Salary, DeptID) values (@Name, @Salary, @DeptID)";
            sqlCommand.Parameters.AddWithValue("@Name", name);
            sqlCommand.Parameters.AddWithValue("@Salary", salary);
            sqlCommand.Parameters.AddWithValue("@DeptID", deptId);
            SqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
        }
    }
}
