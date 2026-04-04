using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_and_Abstract
{
    internal abstract class OfficeMachine
    {
        //prop
        protected string modelName;
        //constractor
        public OfficeMachine(string modelName)
        {
            this.modelName = modelName;
        }
        public void ShowModelInfo()
        {
            Console.WriteLine($"Model: {modelName}");
        }
        public abstract void Start();

    }
}
