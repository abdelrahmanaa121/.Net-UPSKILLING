using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class EvenNumberCollection: IEnumerable<int>
    {
        private List<int> list;
        public EvenNumberCollection(List<int> number)
        {
            list = number;
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in list)
            {
                if (item % 2 == 0)
                {
                    yield return item; 
                }    
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
