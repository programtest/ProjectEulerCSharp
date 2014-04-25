using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEulerLibrary;

namespace ProjectEuler
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// Answer: 906609
    /// </summary>
    public class Problem4
    {
        public static int Solve()
        {
            int minPalindrome = 100001;
            int lowerThreshold = (int)Math.Floor(Math.Sqrt(minPalindrome));

            int maxPalindrome = 0;
            for (int i = 999; i > lowerThreshold; i--)
            {
                for (int j = 999; j > lowerThreshold; j--)
                {
                    int product = i * j;
                    if (Mathematics.IsPalindrome(product) && product > maxPalindrome)
                    {
                        maxPalindrome = product;
                    }
                }
            }

            return maxPalindrome;
        }
    }
}
