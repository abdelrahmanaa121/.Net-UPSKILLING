namespace _3_Constructors_staticmembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Human human1 = new Human(30);
            Human human2 = new Human(30,"Ali");
            //human.Display_Counter();
            Human.Display_Counter();
            #region Syntax Suger
            Human human3 = new Human() { Age=30,Wieght=55.4,Name="Ali"};
            Human human4 = new Human { Age = 30, Wieght = 55.4, Name = "Ali" };
            Human human5 = new Human(30) { Wieght = 55.4, Name = "Ali" };

            #endregion
        }
    }
}
