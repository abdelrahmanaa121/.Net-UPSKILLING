using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _14_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EF in Action
            CompanyDBEntities1 context = new CompanyDBEntities1();
            context.Database.Log = log => Debug.WriteLine(log);

            //foreach (var dept in context.Departments)
            //{
            //    Console.WriteLine(dept.DeptName);
            //}
            ////in DB
            //var query =
            //    context.Departments
            //    .Where(x => x.DeptID > 2)
            //    .Select(x => new { x.DeptID, x.DeptName }).ToList();
            ////in memory
            //var query2 =
            //    context.Departments.ToList()
            //    .Where(x => x.DeptID > 2)
            //    .Select(x => new { x.DeptID, x.DeptName });

            ///*Expression<T> expression;
            //expression.Compile();*/
            ////IQueryable

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"ID: {item.DeptID} Name: {item.DeptName}");
            //}
            //foreach (var item in query2)
            //{
            //    Console.WriteLine($"ID: {item.DeptID} Name: {item.DeptName}");
            //}
            #endregion
            #region UPDATE
            ////UPDATE
            //Employee employee = context.Employees.FirstOrDefault();
            //var entityentry = context.Entry(employee);
            //Console.WriteLine(entityentry.State);
            //employee.Salary = 20000;
            //context.ChangeTracker.DetectChanges();
            //Console.WriteLine(entityentry.State);
            //Console.WriteLine(employee.Salary);
            //context.SaveChanges();
            //Employee employee1 = context.Employees.AsNoTracking().FirstOrDefault();
            #endregion
            #region INSERT
            //Department department = new Department()
            //{
            //    DeptName = "HR"
            //};
            //context.Departments.Add(department);
            //context.SaveChanges();
            #endregion
            #region DELETE
            //Employee employee3 = context.Employees.FirstOrDefault();
            //context.Employees.Remove(employee3);
            //context.SaveChanges();
            #endregion
            #region Relationships

            #endregion
        }
    }
}
