using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_advtopics
{
    internal static class Extension
    {
        public static List<int> Filter(this List<int> items, Predicate<int> predicate)
        {
            List<int> result = new List<int>();
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
