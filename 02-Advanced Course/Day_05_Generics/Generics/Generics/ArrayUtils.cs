using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class ArrayUtils
    {
        public static void ReverseArray<T>(T[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                T temp = array[left];
                array[right] = array[left];
                array[right] = temp;
                left++;
                right--;
            }
        }
        public static T FindMax<T>(T[] array) where T:IComparable<T>
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.", nameof(array));

            T max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(max) > 0)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}
