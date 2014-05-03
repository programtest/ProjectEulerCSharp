using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEulerLibrary;

namespace ProjectEuler
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// Find the sum of all the primes below two million.
    /// Answer: 142913828922
    /// </summary>
    public class Problem10
    {
        public static long Solve()
        {
            List<int> primeNums = Mathematics.GetPrimeNums(1999999);

            long sum = 0;
            foreach (int primeNum in primeNums)
            {
                sum += primeNum;
            }

            return sum;
        }
    }
}
