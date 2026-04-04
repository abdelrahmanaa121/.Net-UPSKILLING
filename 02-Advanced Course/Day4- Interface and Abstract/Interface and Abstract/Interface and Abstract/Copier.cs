using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_and_Abstract
{
    internal class Copier:OfficeMachine
    {
        public Copier(string modelname) : base(modelname) { }
        public override void Start()
        {
            Console.WriteLine("Copier is starting up...");
        }
    }
}
