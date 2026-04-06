using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Number_Iterator
{
    internal class MyList : IEnumerable<int>
    {
        private int[] items;
        private int count;
        public MyList(int capacity = 4) //capacity represent default design space req.
        {
            items = new int[capacity]; //here u can change the capacity by passing new one
            count = 0; //represnt the real number of elemnt in Mylist
        }
        public void Add(int num)
        {
            if (count == items.Length)
            {
                Resize();
            }
            items[count] = num;
            count++;
        }
        private void Resize()
        {
            int newSize = items.Length * 2;
            int[] newArray = new int[newSize];
            Array.Copy(items, newArray, items.Length);
            items = newArray;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] % 2  != 0)
                {
                    yield return items[i];
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
