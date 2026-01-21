using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Outer
    {
        int x;
        public XYZ_for_IEnumrable GetInner()
        {
            return new Inner();
        }
        class Inner:XYZ_for_IEnumrable
        {
            Outer outer;
            public Inner()
            {
                new Outer();
                outer.x = 1;
            }

            public int GetCurrent()
            {
                return outer.x;
            }

            public bool MoveNext()
            {
                return true;
            }

            public void Test()
            {

            }
            
        }
    }
}
