using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    internal class DAL
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data source=.; initial catalog=Ddl; integrated security=true; TrustServerCertificate=true");
        SqlDataAdapter adapter = new SqlDataAdapter();
        public DataTable GetEmployees()
        {
            SqlCommand cmd = new SqlCommand("select * from Ddl.Employee", sqlConnection);
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetEmployeesByDepID(int depID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = $"select * from Ddl.Employee where DepartmentID = {depID}";
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetDepartments()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = $"select * from dbo.Department";
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
