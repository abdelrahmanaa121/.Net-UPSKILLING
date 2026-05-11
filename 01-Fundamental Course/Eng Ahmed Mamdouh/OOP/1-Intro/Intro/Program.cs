namespace Intro
{
    internal class Program
    {
        static void Test(int a , Car c)
        {
            a = 15;
            c.speed = 250;
            Console.WriteLine($"inside func{a},{c.speed}");
        }
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.color = "Red";
            car1.speed = 450;
            Car car2 = new Car();
            car2.color = "Green";
            car2.speed = 250;
            //car1 = car2;
            Car car3 = car1;
            int x = 10;
            Test(x, car2);
            Console.WriteLine($"after func{x},{car1.speed}");
            car1.Move();
            car2.Move();
        }
    }
}
