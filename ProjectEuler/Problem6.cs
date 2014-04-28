using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEulerLibrary;

namespace ProjectEuler
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is 1^2 + 2^2 + ... + 10^2 = 385.
    /// The square of the sum of the first ten natural numbers is (1 + 2 + ... + 10)^2 = 3025.
    /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// Answer: 25164150
    /// </summary>
    public class Problem6
    {
        public static long Solve()
        {
            long sumSquared = Mathematics.GetSumOfConsecutiveNumbers(1, 100) * Mathematics.GetSumOfConsecutiveNumbers(1, 100);
            long numbersSquared = Mathematics.GetSumOfConsecutivePositiveSquares(1, 100);
            return sumSquared - numbersSquared;
        }
    }
}
