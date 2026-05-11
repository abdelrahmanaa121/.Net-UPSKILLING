using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Polymorphism_Abstract_Class
{
    internal class Human : Creature
    {
        public string Address;
        public Human() //: base(10)
        {
            //base.Lenght = 10;
            //base.Age = 1;
        }
        public void Think() { }
        public override void Move()
        {
            Console.WriteLine("Humen is moving");
        }
        public override void Eat()
        {
            Console.WriteLine("Humen is eating");
        }
        public void Die()
        {
            Console.WriteLine("Humen is Dead");
        }
    }
}
