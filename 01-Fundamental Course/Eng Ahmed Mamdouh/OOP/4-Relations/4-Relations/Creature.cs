using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Relations
{
    internal abstract class Creature
    {
        protected int Lenght;
        public int Age;
        public int Weight;
        public Creature (int length)
        {
            this.Lenght = length;
        }
        public abstract void Move();
        //{ 
        //    Console.WriteLine("Creature is moving"); 
        //}
        public void Sleep() { }

    }
}
