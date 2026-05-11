using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Relations
{
    internal class Human : Creature
    {
        public string Address;
        public Human() : base(10)
        {
            //base.Lenght = 10;
            base.Age = 1;
        }
        public void Think() { } 
    }
}
