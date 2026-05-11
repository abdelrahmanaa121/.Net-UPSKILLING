namespace Object_Class
{
    internal class Program
    {
        static void EnrollStd(Student student, string crs)
        {
            student.Enroll(crs);
        }
        static void Main(string[] args)
        {
            Student student = new Student() { Grade = 65 };
            EnrollStd(student, "CS50");
            #region Object Class
            Student student1 = new Student();
            Student student2 = new Student();
            student1.Equals(student2);
            Console.WriteLine(student.ToString());
            Console.WriteLine(student.GetHashCode());
            Console.WriteLine(student.GetType());
            Employee employee = new Employee { ID = 1, Salary = 8000 };
            Employee employee2 = new Employee { ID = 1, Salary = 8000, identity = new Identity { key = 100, pass = 200 } };
            Employee employee1 = employee.DeepClone();
            Employee employee3 = employee2.DeepClone();
            #endregion
        }

    }
}
