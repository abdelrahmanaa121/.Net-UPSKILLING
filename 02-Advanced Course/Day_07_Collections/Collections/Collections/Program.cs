using System;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1: MyStringCollection bjective
            //Implement a custom collection class using a built-in collection(e.g., List<string>) and add methods for common operations.
            Console.WriteLine("\nQuestion 1:\n");

            MyStringCollection myStringCollection = new MyStringCollection();
            myStringCollection.Add("Ali");
            myStringCollection.Add("sara");
            myStringCollection.Add("mariam");
            myStringCollection.Add("osama");

            Console.WriteLine("After Add");

            myStringCollection.PrintAll();

            myStringCollection.Remove("sara");

            Console.WriteLine("After Remove");

            myStringCollection.PrintAll();

            Console.WriteLine("Contains??");

            myStringCollection.Contains("sara");
            myStringCollection.Contains("osama");

            Console.WriteLine("final print");

            myStringCollection.PrintAll();

            //Question 2: EvenNumberCollection with IEnumerable<int>
            Console.WriteLine("\nQuestion 2:\n");
            
            List<int> testList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("\nTest 1: Using 'yield return' Method\n");

            EvenNumberCollection T1 = new EvenNumberCollection(testList);
            foreach (var item in T1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTest 2: Using Manual IEnumerator\n");

            EvenNumberCollectionManual T2 = new EvenNumberCollectionManual(testList);
            foreach (var item in T2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
