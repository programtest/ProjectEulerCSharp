using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEulerLibrary;

namespace ProjectEuler
{
    /// <summary>
    /// A Pythagorean triplet is a set of three natural numbers, a less than b less than c, for which, a^2 + b^2 = c^2.
    /// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// Answer: 31875000
    /// </summary>
    public class Problem9
    {
        public static int Solve()
        {
            const int ERROR = -1;

            // Max a value is 332 since a < b < c and a + b + c = 1000.
            int maxAValue = 332;

            for (int aValue = 1; aValue <= maxAValue; aValue++)
            {
                // This equation was acquired by using c = 1000 - a - b and plugging this into the a^2 + b^2 = c^2 equation for c and solving for b.
                double bValue = (500000 - 1000 * aValue) / (1000 - aValue);

                if (!Mathematics.IsInteger(bValue))
                {
                    continue;
                }

                double cValue = Math.Sqrt(aValue * aValue + bValue * bValue);

                if (!Mathematics.IsInteger(cValue))
                {
                    continue;
                }

                return aValue * (int)bValue * (int)cValue;
            }

            return ERROR;
        }
    }
}
