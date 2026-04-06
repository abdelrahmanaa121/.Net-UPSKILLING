namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1: Anonymous Method for Filtering
            Console.WriteLine("\nQ1: Anonymous Method for Filtering\n");

            List<int> numbers = new List<int> { 3, 9, 2, 7, 10, 15 };
            //Anonymous Method
            List<int> Greaterthanfive = numbers.FindAll(delegate (int num)
            {
                return num > 5; 
            });
            Console.WriteLine("Numbers greater than 5:");
            foreach (var item in Greaterthanfive)
            {
                Console.WriteLine(item);
            }

            //Q2: Lambda Expression for Sorting
            Console.WriteLine("\nQ2: Lambda Expression for Sorting\n");

            List<string> stringlist = new List<string> { "Mona", "Ziad", "Ali", "Laila" };
            //lambda expression
            stringlist.Sort((x, y) => x.Length.CompareTo(y.Length));
            foreach (var item in stringlist)
            {
                Console.WriteLine($"{item} , lenght: {item.Length}");
            }

            //Q3: Generic Delegate with Func<>
            Console.WriteLine("\nQ3: Generic Delegate with Func<>\n");

            Func<int, int, int> Addition = (x, y) => x + y;
            int Res = Addition(10, 20);
            Console.WriteLine(Res);

            //Q4: Action<> with Anonymous Method
            Console.WriteLine("\nQ4: Action<> with Anonymous Method\n");
            
            
            Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
            Console.Write("Enter your Name: ");
            greet(Console.ReadLine());
        }
    }
}
