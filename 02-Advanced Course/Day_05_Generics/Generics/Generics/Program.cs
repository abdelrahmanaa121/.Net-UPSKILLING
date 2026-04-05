namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1: Create a utility class ArrayUtils with generic methods
            Console.WriteLine("\nAssignment 1: Create a utility class ArrayUtils with generic methods\n");

            //ReverseArray
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original Array: " + string.Join(", ", numbers));

            ArrayUtils.ReverseArray(numbers);
            Console.WriteLine("Reversed Array: " + string.Join(", ", numbers));

            //FindMax
            double[] temperatures = { 32.5, 45.2, 88.1, 12.0, 76.5 };
            double maxTemp = ArrayUtils.FindMax(temperatures);
            Console.WriteLine($"Max Temperature: {maxTemp}");

            string[] words = { "Apple", "Zebra", "Monkey" };
            string maxWord = ArrayUtils.FindMax(words);
            Console.WriteLine($"Max Word: {maxWord}");

            //Assignment 2: caching mechanism
            Console.WriteLine("\nAssignment 2: caching mechanism\n");

            var MyCache = new Cache<int, string>(3);
            MyCache.Add(1, "Book1");
            MyCache.Add(2, "Book2");
            MyCache.Add(3, "Book3");
            Console.WriteLine("Added 3 items.");
            MyCache.Get(1);
            Console.WriteLine("Accessed Item 1");
            MyCache.Add(4, "Book4");
            Console.WriteLine("Added Item 4");
            try
            {
                MyCache.Get(2);
            }
            catch
            {

                Console.WriteLine("Item 2 not found");
            }
            Console.WriteLine($"Item 1: {MyCache.Get(1)}");
        }
    }
}
