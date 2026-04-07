namespace extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-extension method for DateTime to calculate age:
            Console.WriteLine("\nextension method for DateTime to calculate age\n");

            DateTime BD = new DateTime(1999,12,19);
            Console.WriteLine($"Your Age is {BD.GetAge()}");

            //2-extension method for List<int> that returns the average of even numbers:
            Console.WriteLine("\nextension method for List<int> that returns the average of even numbers\n");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine($"{{{string.Join(",", numbers)}}}");
            Console.WriteLine($"\nAverage is {numbers.AvgOfEvenNumbers()}");

            //3- Write an extension method to make pagination for any collection:
            Console.WriteLine("\nextension method to make pagination for any collection\n");

            List<string> products = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H" };
            var page2 = products.Paginate(3, 2);
            IEnumerable<string> p4 = products.Paginate(4, 2);
            foreach (var item in page2) Console.WriteLine(item);
            Console.WriteLine("");
            foreach (var item in p4) Console.WriteLine(item);

            //4-extension method to convert object to JSON:
            Console.WriteLine("\nextension method to convert object to JSON\n");
            var user = new { name = "Ali", Age = 23, Job = "Software Engineer" };
            Console.WriteLine(user.ToJson());


        }
    }
}
