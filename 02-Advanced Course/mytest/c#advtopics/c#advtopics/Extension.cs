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
        public static string RemoveVowels(this string str)
        {
            char[] vowles = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };
            StringBuilder sb = new StringBuilder();
            foreach (var c in str)
            {
                if (!vowles.Contains(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        public static char GetMiddleChar(this string str)
        {
            return str[str.Length / 2];
        }
        public static char GetASCI(this char c)
        {
            return (char)(int)c;
        }
    }
}
