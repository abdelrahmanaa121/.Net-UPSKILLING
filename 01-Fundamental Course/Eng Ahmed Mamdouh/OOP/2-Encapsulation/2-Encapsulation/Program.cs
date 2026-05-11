namespace _2_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.name = "Ali";
            Employee employee = new Employee();
            
            //employee.SetSalary(10000);
            //Console.WriteLine(employee.GetSalary());
        }
    }
}
