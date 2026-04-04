using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interface_and_Abstract
{
    internal class SmartCopier : OfficeMachine, IPrinter, IScanner, IFax, IMaintenance
    {

        
        public SmartCopier(string modelname) : base(modelname) { }
        public override void Start()
        {
            Console.WriteLine("SmartCopier is initializing...");
        }

        public void PowerOn()
        {
            Console.WriteLine("SmartCopier is powered on.");
        }

        public void Print(string documentName)
        {
            Console.WriteLine($"SmartCopier printing: {documentName}");
        }

        public void Scan(string doc)
        {
            Console.WriteLine($"SmartCopier scanning: {doc}");
        }

        public void SelfCheck()
        {
            Console.WriteLine("SmartCopier self-check in progress...");
        }

        void IFax.Fax(string doc, string number)
        {
            Console.WriteLine($"SmartCopier faxing: {doc} to {number}");
        }
    }
}
