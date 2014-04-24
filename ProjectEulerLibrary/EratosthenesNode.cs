using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerLibrary
{
    public class EratosthenesNode
    {
        public int Value { get; set; }
        public bool IsPrime { get; set; }

        public EratosthenesNode()
        {
            IsPrime = true;
        }

        public EratosthenesNode(int value)
        {
            Value = value;
            IsPrime = true;
        }

        public EratosthenesNode(int value, bool isPrime)
        {
            Value = value;
            IsPrime = isPrime;
        }
    }
}
