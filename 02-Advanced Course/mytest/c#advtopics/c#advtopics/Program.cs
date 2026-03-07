namespace c_advtopics
{
    internal class Program
    {
        #region extension methods
        static void Display(List<int> items, Predicate<int> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
        static List<int> Filter(List<int> items, Predicate<int> predicate)
        {
            List<int> result = new List<int>();
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        #endregion
        static void Main(string[] args)
        {
            #region anonymous object
            ////Employee employee = new Employee();

            ////object employee = new { Name="Jhon", Salary=8444};
            //var employee = new { Name = "Jhon", Salary = 8444 };
            //var employee2 = new { Name = "Jhon Doe", Salary = "5600" };
            //var employee4 = new { Name = "Jhon Doe", salary = 8100 };

            //var employee3 = new { Name = "Jhon", Salary = 8000, Address = "Cairo" };

            //////modify
            //string name = employee.Name;


            ////employee.Salary = 1000;

            //var x = 8;
            //var y = 8.5;
            //var h = "Hi";
            ////var x; 
            //////readiblity for code 
            //Dictionary<int, Dictionary<int, List<Employee>>> keyValuePairs = new Dictionary<int, Dictionary<int, List<Employee>>>();

            //var keyValuePairs2 = new Dictionary<int, Dictionary<int, List<Employee>>>();

            #endregion

            #region extension methods
            ////using one function
            List<int> ints = new List<int> { 12, -2, 4, 8, 6, 4 };
            //Display(ints, n => n > 0);
            /////sepeartion of concern
            List<int> PositiveNumbers = Filter(ints, n => n > 0);
            ////extension methods
            List<int> PositiveNumbers2 = ints.Filter( n => n > 0);

            foreach (var number in PositiveNumbers)
            {
                Console.WriteLine(number);
            }
            #endregion

            #region Sequence

            #endregion
        }
    }
}
