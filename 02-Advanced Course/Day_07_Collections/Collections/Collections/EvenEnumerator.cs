using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class EvenEnumerator : IEnumerator<int>
    {
        private List<int> Data;
        private int index = -1;
        public EvenEnumerator(List<int> data)
        {
            Data = data;
        }
        public int Current => Data[index];

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            while (++index < Data.Count)
            {
                if (Data[index] % 2 == 0) return true;
            }
            return false;
        }

        public void Reset() => index = -1;
        
    }
}
