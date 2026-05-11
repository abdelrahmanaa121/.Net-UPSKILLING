using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Polymorphism_Abstract_Class
{
    internal abstract class Creature
    {
        protected int Lenght;
        public int Age;
        public int Weight;
        public Creature()
        {
            //this.Lenght = length;
        }
        public virtual void Move() 
        {
            Console.WriteLine("Creature is moving");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Creature is eating");
        }
        public void Die()
        {
            Console.WriteLine("Creature is Dead");
        }
        public void Sleep() { }
    }
}
