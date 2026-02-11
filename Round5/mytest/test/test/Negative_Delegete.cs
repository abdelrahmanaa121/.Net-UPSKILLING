using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Negative_Delegete : IChecker
    {
        public bool Check(int number)
        {
            return number < 0;
        }
    }
}
