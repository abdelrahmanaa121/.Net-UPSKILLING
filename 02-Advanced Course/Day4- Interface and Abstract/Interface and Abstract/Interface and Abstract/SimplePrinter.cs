using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_and_Abstract
{
    internal class SimplePrinter : IPrinter
    {
        public void Print(string documentName)
        {
            Console.WriteLine($"Printing document: {documentName}");
        }
    }
}
