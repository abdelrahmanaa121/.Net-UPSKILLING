using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Mylist<T>//خلينا الليست جينريك
                            ////where T: class,new()
                            /////where T:Employee
    {
        //array
        T[] items;
        int index;
        public Mylist()
        {
            items = new T[5];
            index = -1;//prefix
            //index = 0; >> postfix

        }
        public virtual void Add(T item)
        {
            //if (item > 0)
            //{

            //}
            //item = new()
            if (index == items.Length -1)
            {
                Extend();
            }
            items[++index] = item; //prefix
            //items[index++] = item; >>postfix
        }
        public T GetByIndex()
        {
            return items[index];
        }
        private void Extend()
        {
            T[] newitems = new T[items.Length * 2];
            for (int i = 0; i < items.Length; i++)
            {
                newitems[i] = items[i];
            }
            items = newitems;
        }
    }
}
