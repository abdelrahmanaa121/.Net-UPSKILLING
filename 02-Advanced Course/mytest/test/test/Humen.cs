using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Humen : IMovable, IComparable //: GameMember
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Humen() { }

        public void Move() //عملت امبلمبنت للانترفيس
        {
            Console.WriteLine("Humen is moving");
        }

        public int CompareTo(object obj)
        {
            Humen humen = obj as Humen;
            if (humen == null)
            {
                return 0;
            }
            if (this.Age > humen.Age)
            {
                return 1;
            }
            else if (this.Age < humen.Age) 
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        //public override void Move()
        //{
        //    Console.WriteLine("Humen is moving");

        //}
    }
}
