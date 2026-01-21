using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Mylist_For_IEnumrable:IEnumerable
    {
        int[] items;
        int index;

        public Mylist_For_IEnumrable()
        {
            items = new int[5];
            index = -1;
        }

        public void Add(int item)
        {
            if (index == items.Length - 1)
            { 
                Extend(); 
            }

            items[++index] = item;
        }

        private void Extend()
        {
            int[] temp = new int[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                temp[i] = items[i];
            }
            items = temp;
        }
        public int GetByIndex(int index)
        {
            return items[index];
        }
        public int GetCount()
        {
            return items.Length;
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        class Iterator:IEnumerator //inner calss الوسيط
        {
            Mylist_For_IEnumrable mylist;
            int index;
            public Iterator(Mylist_For_IEnumrable list)
            {
                //mylist = new Mylist_For_IEnumrable(); دع غلط 
                this.mylist = list;
                index = -1;

            }

            public object Current
            {
                get
                {
                    return mylist.items[index];
                }
            }
            public bool MoveNext()
            {
                index ++;
                if(index > mylist.index)
                    return false;
                return true;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
