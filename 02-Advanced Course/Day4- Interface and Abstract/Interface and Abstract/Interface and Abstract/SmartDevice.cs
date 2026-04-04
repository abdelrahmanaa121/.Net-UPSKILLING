using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_and_Abstract
{
    internal class SmartDevice : IPrinter, IScanner, IFax
    {
        public void Fax(string doc, string number)
        {
            Console.WriteLine($"Sending fax: {doc} to {number}");
        }

        public void Print(string documentName)
        {
            Console.WriteLine($"Printing: {documentName}");
        }

        public void Scan(string doc)
        {
            Console.WriteLine($"Scannig: {doc}");
        }
    }
}
