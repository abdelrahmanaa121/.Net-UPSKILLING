using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Car : IMovable,IComparable//: GameMember 
    {
        public string Color { get; set; }
        public int Model { get; set; }
        public string Make { get; set; }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public void Move()//عملت امبلمبنت للانترفيس
        {
            Console.WriteLine("car is moving"); 
        }

        //public override void Move()
        //{
        //    Console.WriteLine("car is moving");
        //}
        //    public override void test()
        //    {
        //        Console.WriteLine("test in car");
        //    }
    }
}
