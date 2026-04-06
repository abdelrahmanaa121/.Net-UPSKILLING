namespace Odd_Number_Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList(5);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Console.WriteLine("Odd numbers in the list:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
