using ADO_Task.Models;

namespace ADO_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  1.Insert a new employee
            Console.WriteLine("\n--- Inserting New Employee ---\n");
            Console.WriteLine("Do you want to insert new employee? (y/n)");
            string insertemp = Console.ReadLine();
            
            if (insertemp.ToLower() == "y" || insertemp.ToUpper() == "Y")
            {
                DAL dAL = new DAL();
                Console.Write("New Employee Name : ");
                string name = Console.ReadLine();
                Console.Write("New Employee Salary : ");
                decimal salary = decimal.Parse(Console.ReadLine());
                Console.Write("New Employee Department ID : ");
                int depid = int.Parse(Console.ReadLine());
                dAL.InsertEmployee(name, salary, depid);
                Console.WriteLine("Employee inserted successfully");
            }
            else
            {
                Console.WriteLine("No Employee was Inserted");
            }


            // 2. Display all employees
            Console.WriteLine("\n--- All Employees ---\n");
            Employees_BLL employees_BLL = new Employees_BLL();
            List<Employees> employees = employees_BLL.GetAllEmployees();
            foreach (Employees emp in employees)
            {
                Console.WriteLine($"ID: {emp.ID} | Name: {emp.Name} | Salary: {emp.Salary} | Dept ID: {emp.DeptID}");
            }

            // 3. Display all departments
            Console.WriteLine("\n--- All departments ---\n");
            Departments_BLL departments_BLL = new Departments_BLL();
            Console.WriteLine("Do you want to see the employees inside each department? (y/n)");
            string userinput = Console.ReadLine();
            bool showEmp = false;
            if (userinput.ToLower() == "y" || userinput.ToUpper() == "Y")
            {
                showEmp = true;
            }
            List<Departments> departments= departments_BLL.GetAllDepartments(showEmp);
            foreach (Departments dept in departments)
            {
                Console.WriteLine($"Dept ID: {dept.DeptID} | Name: {dept.DeptName}");
                if (dept.Employees != null)
                {
                    if (dept.Employees.Count > 0)
                    {
                        foreach (Employees emp in dept.Employees)
                        {
                            Console.WriteLine($"   -> Employee: {emp.Name} (Salary: {emp.Salary})");
                        }
                    }
                    else
                    {
                        Console.WriteLine("   -> No employees in this department yet.");
                    }
                }
            }
            // 4. Display employees where DeptID = 1
            Console.WriteLine("\n--- Employees in Department 1 ---\n");
            List<Employees> employees1 = employees_BLL.GetEmployeesByDept(1);
            foreach (Employees emp in employees1)
            {
                Console.WriteLine($"ID: {emp.ID} | Name: {emp.Name} | Salary: {emp.Salary}");
            }
            
            
        }
    }
}
