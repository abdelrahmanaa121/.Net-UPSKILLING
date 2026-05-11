using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Polymorphism_Abstract_Class
{
    internal class Animal : Creature
    {
        public override void Move()
        {
            Console.WriteLine("Insect is moving");
        }
    }
}
