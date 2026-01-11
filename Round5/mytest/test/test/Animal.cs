using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Animal : IMovable //: GameMember
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal() { }

        public void Move()//عملت امبلمبنت للانترفيس
        {
            Console.WriteLine("Animal is moving");
        }
        //public override void Move()
        //{
        //    Console.WriteLine("Animal is moving");
        //}
    }
}
