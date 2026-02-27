using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Vechile
    {
        public int Speed { get; set; }
        public string Brand { get; set; }
        public virtual void Move()
        {
            Console.WriteLine("vec is moving");
        }
        public virtual void test()
        {
            Console.WriteLine("test in vec");
        }

    }
}
