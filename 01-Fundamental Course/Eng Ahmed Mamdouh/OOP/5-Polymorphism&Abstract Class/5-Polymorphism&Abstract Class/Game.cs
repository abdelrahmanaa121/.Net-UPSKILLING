using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Polymorphism_Abstract_Class
{
    internal class Game
    {
        #region NoramlSolution
        Human[] humans = new Human[10];
        Animal[] animals = new Animal[10];
        Insect[] insects = new Insect[10];
        public void AddHuman(Human human) { }
        public void AddAnimal(Animal animal) { }
        public void AddInsects(Insect insect) { }
        
        public void MoveHuman() { }
        public void MoveAnimal() { }
        public void MoveInsect() { }
        public void StartGame()
        {
            MoveHuman();
            MoveAnimal();
            MoveInsect();
        }
        #endregion
        #region Generalization
        Creature[] creatures = new Creature[100];
        public void AddCreature(Creature creature) { }
        public void Movecreature() { }
        public void StartGameG() { Movecreature(); }
        #endregion
    }
}
