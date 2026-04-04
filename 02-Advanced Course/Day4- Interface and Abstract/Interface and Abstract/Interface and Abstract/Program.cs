namespace Interface_and_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Basic Interface Implementation
            Console.WriteLine("\n1. Basic Interface Implementation\n");

            SimplePrinter simplePrinter = new SimplePrinter();
            simplePrinter.Print("Invoice.pdf");

            //2. Implementing Multiple Interfaces
            Console.WriteLine("\n2. Implementing Multiple Interfaces\n");

            SmartDevice smartDevice = new SmartDevice();
            smartDevice.Print("Invoice.pdf");
            smartDevice.Scan("Invoice2.pdf");
            smartDevice.Fax("Invoice.pdf", "01031443563");

            //3. Interface Inheritance
            Console.WriteLine("\n3. Interface Inheritance\n");

            IMaintenance serviceMachine = new ServiceMachine();
            serviceMachine.PowerOn();
            serviceMachine.SelfCheck();

            //4. Explicit Interface Implementation
            Console.WriteLine("\n4. Explicit Interface Implementation\n");

            SecurePrinter securePrinter = new SecurePrinter();
            //securePrinter. >> this is hidden (not work)
            IPrinter SecurePrint = securePrinter;
            SecurePrint.Print("Top Secret.pdf");

            //5. Abstract Class with Constructor and Method
            Console.WriteLine("\n5. Abstract Class with Constructor and Method\n");

            Copier copier = new Copier("Copier Model");
            copier.ShowModelInfo();
            copier.Start();

            //6. Final Integration: SmartCopier
            Console.WriteLine("\n6. Final Integration: SmartCopier\n");

            SmartCopier smartCopier = new SmartCopier("SmartCopier");
            smartCopier.ShowModelInfo();
            smartCopier.Start();
            smartCopier.Print("file1.pdf");
            smartCopier.Scan("file2.pdf");
            IFax fax = smartCopier;
            fax.Fax("file1.pdf", "01031443563");
            smartCopier.PowerOn();
            smartCopier.SelfCheck();

        }
    }
}
