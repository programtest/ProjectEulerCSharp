using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerLibrary
{
    /// <summary>
    /// Class contains methods related to mathematical calculations.
    /// </summary>
    public class Mathematics
    {
        public static int ERROR = -1;

        /// <summary>
        /// Method calculates the least common multiple from a list of numbers.
        /// Pre-assumptions: The resulting least common multiple is less than the max possible integer value (2^32).
        /// </summary>
        /// <param name="nums">List of numbers.</param>
        /// <returns>Least common multiple.</returns>
        public static int GetLeastCommonMultiple(List<int> nums)
        {
            // Check input.
            if (nums == null || nums.Count == 0)
            {
                throw new ArgumentException("nums list cannot be null or empty.", "nums");
            }
            
            // Create a list to track the multiples of each number.
            List<int> numTracker = nums.ToList();
            
            // Get the max index and value.
            int maxValue = GetMaxNum(nums);
            int maxIndex = GetMaxNumIndex(nums);

            // Let each of the nums "catch up" to the max.
            while (true)
            {
                // Increment each element until it is equal to or greater than max value.
                for (int i = 0; i < numTracker.Count; i++)
                {
                    while (numTracker[i] < maxValue)
                    {
                        numTracker[i] += nums[i];
                    }
                }

                // If all elements are equal to the max value, then max value is the least common multiple.
                if (AreElementsEqualToNum(numTracker, maxValue))
                {
                    break;
                }

                maxValue = numTracker[maxIndex] += nums[maxIndex];
            }

            return maxValue;
        }

        /// <summary>
        /// Method checks to see if all of the elements in a list are equal to the specified number.
        /// </summary>
        /// <param name="nums">List of numbers.</param>
        /// <param name="comparisonNum">Comparison number.</param>
        /// <returns>Bool value indicating if all of the elements in a list are equal to the specified number.</returns>
        public static bool AreElementsEqualToNum(List<int> nums, int comparisonNum)
        {
            // Check input.
            if (nums == null || nums.Count == 0)
            {
                throw new ArgumentException("nums list cannot be null or empty.", "nums");
            }

            foreach (int num in nums)
            {
                if (num != comparisonNum)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Method gets the index of the maximum number in a list of numbers.  If there are multiple maximum numbers in the list,
        /// the method will return the index of the first occurrence of the maximum number.
        /// </summary>
        /// <param name="nums">List of numbers.</param>
        /// <returns>Index of the maximum number.</returns>
        public static int GetMaxNumIndex(List<int> nums)
        {
            // Check input.
            if (nums == null || nums.Count == 0)
            {
                throw new ArgumentException("nums list cannot be null or empty.", "nums");
            }

            int max = int.MinValue;
            int maxIndex = -1;
            for(int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        /// <summary>
        /// Method gets the maximum number from a list of numbers.
        /// </summary>
        /// <param name="nums">List of numbers.</param>
        /// <returns>Maximum number.</returns>
        public static int GetMaxNum(List<int> nums)
        {
            // Check input.
            if (nums == null || nums.Count == 0)
            {
                throw new ArgumentException("nums list cannot be null or empty.", "nums");
            }

            int max = int.MinValue;
            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;
        }

        /// <summary>
        /// Method determines if an integer is a palindrome or not.  In this method, negative numbers are not considered to be palindromic.
        /// </summary>
        /// <param name="num">Possible palindromic number.</param>
        /// <returns>Bool indicating if a number is a palindrome or not.</returns>
        public static bool IsPalindrome(int num)
        {
            // Check input.
            if (num < 0)
            {
                return false;
            }

            // Convert number to string for easier indexing.
            string numAsString = num.ToString();

            // Set left, right pointers.
            int left = 0;
            int right = numAsString.Length - 1;

            // While left pointer is less than right pointer.
            while (left < right)
            {
                // Compare characters.  If they are different return false.
                if (numAsString[left] != numAsString[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }

        /// <summary>
        /// Method gets all multiples of a number which are less than a specified maximum value.
        /// </summary>
        /// <param name="num">Number for which the multiples will be calculated.</param>
        /// <param name="max">Multiples will be calculated up to this value.</param>
        /// <returns>List of multiples.</returns>
        public static List<int> GetMultiples(int num, int max)
        {
            // Check inputs.
            if (num <= 0)
            {
                throw new ArgumentOutOfRangeException("num", "num parameter must consist of a positive integer value.");
            }
            if (max <= 0)
            {
                throw new ArgumentOutOfRangeException("max", "max parameter must consist of a positive integer value.");
            }
            if(max <= num)
            {
                throw new ArgumentOutOfRangeException("max", "max parameter value must be greater than num parameter value.");
            }
            
            List<int> multiples = new List<int>();

            for (int i = num; i < max; i += num)
            {
                multiples.Add(i);
            }

            return multiples;
        }

        /// <summary>
        /// Method gets the prime numbers less than or equal to the specified max value by using the
        /// Sieve of Eratosthenes algorithm.
        /// </summary>
        /// <param name="max">Max value.</param>
        /// <returns>List of prime numbers less than or equal to the specified max value.</returns>
        public static List<int> GetPrimeNums(int max)
        {
            List<EratosthenesNode> primeNums = new List<EratosthenesNode>();

            // Initially populate list with 2 dummy nodes to keep the list index in line with the number values.
            primeNums.Add(new EratosthenesNode(0, false));
            primeNums.Add(new EratosthenesNode(0, false));

            // Populate list with all ints from 2 to max.
            for (int i = 2; i <= max; i++)
            {
                primeNums.Add(new EratosthenesNode(i));
            }

            // Calculate floor of the square root of max.  You only need to go up to the square root due to the following explanation:
            // http://stackoverflow.com/questions/5811151/why-do-we-check-upto-the-square-root-of-a-prime-number-to-determine-if-it-is-pri
            int stopNum = (int)Math.Floor(Math.Sqrt(max));

            for (int j = 2; j <= stopNum; j++)
            {
                int startNum = j * j;
                for (int k = startNum; k < primeNums.Count; k++)
                {
                    if (primeNums[k].Value % j == 0)
                    {
                        primeNums[k].IsPrime = false;
                    }
                }
            }

            // Create a list consisting of the node values which are prime.
            return primeNums.Where(x => x.IsPrime).Select(x => x.Value).ToList();
        }

        /// <summary>
        /// Method gets all Fibonacci numbers below the specified max value by using dynamic programming.
        /// </summary>
        /// <param name="max">Max value.</param>
        /// <returns>List of all Fibonacci numbers below the specified max value.</returns>
        public static List<int> GetFibonacciNums(int max)
        {
            // Check input.
            if (max <= 0)
            {
                throw new ArgumentOutOfRangeException("max", "max value must be greater than one.");
            }
            if (max == 1)
            {
                return new List<int>() { 0 };
            }

            // Create return list.
            List<int> fibonacciNums = new List<int>();

            // Set the first two values.
            fibonacciNums.Insert(0, 0);
            fibonacciNums.Insert(1, 1);

            int index = 2;

            while (true)
            {
                int currentNum = fibonacciNums[index - 1] + fibonacciNums[index - 2];
                if (currentNum < max)
                {
                    fibonacciNums.Insert(index, currentNum);
                }
                else
                {
                    break;
                }

                index++;
            }

            return fibonacciNums;
        }
    }
}
