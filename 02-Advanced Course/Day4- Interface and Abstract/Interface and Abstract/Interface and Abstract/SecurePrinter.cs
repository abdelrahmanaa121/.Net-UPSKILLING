using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_and_Abstract
{
    internal class SecurePrinter : IPrinter
    {
        void IPrinter.Print(string documentName)
        {
            Console.WriteLine($"SecurePrinter Printing confidential document: {documentName}");
        }  
        
    }
}
