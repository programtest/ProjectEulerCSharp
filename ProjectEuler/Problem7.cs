using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEulerLibrary;

namespace ProjectEuler
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10 001st prime number?
    /// Answer: 104743
    /// </summary>
    public class Problem7
    {
        public static int Solve()
        {
            List<int> primeNums = Mathematics.GetPrimeNums(110000);

            return primeNums[10000];
        }
    }
}
