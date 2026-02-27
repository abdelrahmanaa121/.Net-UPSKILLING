namespace Array_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] ints = new int[5] { 1, 2, 3, 4, 5 };
            int last = ints[ints.Length - 1];
            int last2 = ints[^1]; //in version c# 8.0

            //Range

            int[] numbers = { 10, 20, 30, 40, 50 };
            int[] firstthree = numbers[..3];
            int[] firstthree1 = numbers[1..3];
            int[] firstthree2= numbers[..3];

            //

        }
    }
    
}
