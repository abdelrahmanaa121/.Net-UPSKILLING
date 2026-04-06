using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class EvenNumberCollectionManual : IEnumerable<int>
    {
        private List<int> list;
        public EvenNumberCollectionManual(List<int> _list) => list = _list;
        public IEnumerator<int> GetEnumerator()
        {
            return new EvenEnumerator(list);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
