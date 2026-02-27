using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Game
    {
        //Humen[] humens = new Humen[10];
        //Animal[] animals = new Animal[10];
        //Car[] cars = new Car[10];

        //هلغي ديه و اعمل بدالها انترفيس
        //GameMember[] gameMembers = new GameMember[10];

        //النترفيس 
        IMovable[] gameMembers = new IMovable[10];

        //int humenindex = 0;
        //int animalindex = 0;
        int gamememberindex = 0;
        public Game() { }
        //public void AddHuman(Humen humen)
        //{
        //    humens[humenindex++] = humen;
        //}
        //public void Addanimal(Animal animal)
        //{
        //    animals[animalindex++] = animal;
        //}
        public void AddGameMember(IMovable member)
        {
            gameMembers[gamememberindex++] = member;
        }
        public void StartGame()
        {
            //MoveHuman();
            //MoveAnimal();
            MoveGameMember();
            
           
        }
        private void MoveGameMember()
        {
            for (int i = 0; i < gamememberindex; i++)
            {
                gameMembers[i].Move();
            }
        }
        //private void MoveHuman()
        //{
        //    for (int i = 0; i < humenindex; i++)
        //    {
        //        humens[i].Move();
        //    }
        //}
        //private void MoveAnimal()
        //{
        //    for (int i = 0; i < humenindex; i++)
        //    {
        //        animals[i].Move();
        //    }
        //}
    }
}
