namespace _5_Polymorphism_Abstract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Creature human2 = new Human(); //polymorhism
            //Human human1 = new Creature(); لا يجوز
            human.Think();
            //human2.Think(); cant see think here
            human.Move(); //Act as ref of human
            human2.Move(); //Act as ref of creature
            human.Die(); //Act as ref of human
            human2.Die(); //Act as ref of creature
            #region Game normal solution
            Animal animal = new Animal();
            Insect insect = new Insect();
            Game game = new Game();
            game.AddHuman(human);
            game.AddInsects(insect);
            game.AddAnimal(animal);
            game.StartGame();
            #endregion
            #region GameGeneralized
            Game game1 = new Game();
            game1.AddCreature(human);
            game1.AddCreature(animal);
            game1.AddCreature(insect);
            game1.Movecreature();
            game1.StartGameG();
            #endregion
            #region Abstract Class
            //Creature creature = new Creature(); >>> can't create an obj from abstract class 
            Creature creature1 = new Human();
            Creature[] creatures = new Creature[100];
            #endregion
        }
    }
}
