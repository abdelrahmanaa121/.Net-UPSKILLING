using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class MyAdvancedList<T> : Mylist<T> where T : Employee
    {
        public void Resize()
        {

        }
        public override void Add(T item)
        {
            base.Add(item);
        }
    }
}
