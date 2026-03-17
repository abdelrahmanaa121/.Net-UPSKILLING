namespace Function
{
    internal class Program
    {
        static void PrintHello()
        {
            Console.WriteLine("Hello, World!");

        }
        /*static void Add()
        {
            int first = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());
            int res = first+sec;
            Console.WriteLine(res);
        }*/
        static int Add_withinput(int first ,int sec)
        {
            int res = first + sec;
            Console.WriteLine(res);
            return res;
        }
        static bool Is_Even(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else return false;
        }
        //Function over load
        static double Add_withinput(double first, double sec)
        {
            double res = first + sec;
            Console.WriteLine(res);
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            PrintHello();
            //Add();
            Add_withinput(8,7);
            Add_withinput(5.6,8.7);
            bool even = Is_Even(78);
            int z = Add_withinput(5,8);
            Console.WriteLine("End");

        }
    }
}
