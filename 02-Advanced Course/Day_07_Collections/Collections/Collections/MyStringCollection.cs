using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class MyStringCollection
    {
        private List<string> list;
        public MyStringCollection()
        {
            list = new List<string>();
        }
        public void Add(string item)
        {
            list.Add(item);
        }
        public bool Remove(string item)
        {
            return list.Remove(item);
        }
        public bool Contains(string item)
        {
            if (list.Contains(item))
            {
                Console.WriteLine($"{item} found");
            }
            else
            {
                Console.WriteLine($"{item} not found");
            }
            return list.Contains(item);
        }
        public void PrintAll()
        {
            foreach (var item in list)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
