using System;
using System.Data; // Required for DataTable and DataRow
using Lecture.Models;
using Microsoft.Data.SqlClient;
// Removed using System.Data.SqlClient; to prevent ambiguity errors

namespace Lecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1 of Lec
            ////--------1-Create Connection with DB--------
            //SqlConnection sqlConnection = new SqlConnection(@"Data source=.; initial catalog=Ddl; integrated security=true; TrustServerCertificate=true");
            ////--------2-prepare SQL commaned--------
            //SqlCommand sqlCommand = new SqlCommand("select * from Ddl.Employee", sqlConnection);
            ////OR use properties:-
            ////SqlCommand sqlCommand = new SqlCommand();
            ////sqlCommand.Connection = sqlConnection;
            ////sqlCommand.CommandText = "select * from Ddl.Employee";

            ////--------3-Modes--------

            //#region Connected Mode
            //Console.WriteLine("--- Connected Mode ---");
            ////open connection
            //sqlConnection.Open();
            ////excute & Read
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read()) //same as etrator
            //{
            //    //sqlDataReader[0]
            //    int id = (int)sqlDataReader["Id"];
            //    string name = sqlDataReader["Name"].ToString();
            //    DateTime birthdate = DateTime.Parse(sqlDataReader["BirthDate"].ToString());
            //    Console.WriteLine($"Id: {id} \t Name: {name} \t BirhDate : {birthdate}");
            //}
            ////close connection
            //sqlConnection.Close();

            //////ExecuteScalar
            //sqlConnection.Open();
            //SqlCommand sqlCommand1 = new SqlCommand();
            //sqlCommand1.Connection = sqlConnection;
            //sqlCommand1.CommandText = "Select count(*) from  Ddl.Employee";
            //int count = (int)sqlCommand1.ExecuteScalar();
            //Console.WriteLine($"Count = {count}");
            //sqlConnection.Close();

            ////Update
            //SqlCommand sqlCommand2 = new SqlCommand("update Ddl.Employee set Salary = Salary * 1.1 where Id > 2", sqlConnection);
            //sqlConnection.Open();
            //sqlCommand2.ExecuteNonQuery();
            //sqlConnection.Close();
            //#endregion

            //#region Disconnected Mode
            //Console.WriteLine("\n--- Disconnected Mode ---");

            //// 1. Create the DataAdapter using your existing command
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //// 2. Create the DataTable in memory
            //DataTable dataTable = new DataTable();
            //// 3. Fill the table (DataAdapter automatically opens and closes the connection)
            //sqlDataAdapter.Fill(dataTable);
            //// 4. Read from the disconnected DataTable
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    int id = (int)row["Id"];
            //    string name = row["Name"].ToString();
            //    DateTime birthdate = DateTime.Parse(row["BirthDate"].ToString());
            //    Console.WriteLine($"Id: {id} \t Name: {name} \t BirhDate : {birthdate}");
            //}
            //#endregion
            #endregion

            #region Part 2 of lec
            ////1-DAL
            //DAL dAL = new DAL();
            //DataTable EmpTable = dAL.GetEmployees();
            //foreach (DataRow row in EmpTable.Rows)
            //{
            //    int id = (int)row["Id"];
            //    string name = row["Name"].ToString();
            //    DateTime birthdate = DateTime.Parse(row["BirthDate"].ToString());
            //    Console.WriteLine($"Id: {id} \t Name: {name} \t BirhDate : {birthdate}");
            //}

            //2-BBl
            //BLL bLL = new BLL();
            //List<Employee> employees = bLL.GetEmployees();

            //BLL bLL = new BLL();
            //bLL.GetEmployeesByDepID(3);

            //BLL bLL = new BLL();
            //List<Department> departments = bLL.GetDepartments(true);

            
            #endregion
        }
    }
}