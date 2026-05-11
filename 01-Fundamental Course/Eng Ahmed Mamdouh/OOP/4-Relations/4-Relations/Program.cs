namespace _4_Relations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Association
            Instructor instructor = new Instructor();
            Marker marker = new Marker();
            instructor.writeOnBoard(marker);
            #endregion
            #region Aggregation
            Room room = new Room();
            room.InstrucEnter(instructor);
            #endregion
            #region Inheritance
            Human human = new Human();
            //Creature creature = new Creature();
            Creature creature = new Human();

            #endregion
            #region Var
            int x = 5;
            //int y = 5.5; will not accept
            var y = 5.5;
            #endregion
        }
    }
}
