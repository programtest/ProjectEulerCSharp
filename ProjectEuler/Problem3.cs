using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEulerLibrary;

namespace ProjectEuler
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// Answer: 6857
    /// </summary>
    public class Problem3
    {
        public static int Solve()
        {
            Int64 inputNumber = 600851475143;

            // Get square root of the input number.
            int squareRoot = (int)Math.Sqrt(600851475143);

            // Get all of the prime numbers below the square root of the input number.
            List<int> primeNums = Mathematics.GetPrimeNums(squareRoot);

            // Starting from the last prime number, check to see if the prime number divides the input number cleanly.
            for (int i = primeNums.Count - 1; i >= 0; i--)
            {
                if (inputNumber % primeNums[i] == 0)
                {
                    return primeNums[i];
                }
            }

            return -1;
        }
    }
}
