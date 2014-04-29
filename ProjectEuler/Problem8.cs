using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEulerLibrary;

namespace ProjectEuler
{
    /// <summary>
    /// Find the greatest product of five consecutive digits in the 1000-digit number.
    /// 73167176531330624919225119674426574742355349194934
    /// 96983520312774506326239578318016984801869478851843
    /// 85861560789112949495459501737958331952853208805511
    /// 12540698747158523863050715693290963295227443043557
    /// 66896648950445244523161731856403098711121722383113
    /// 62229893423380308135336276614282806444486645238749
    /// 30358907296290491560440772390713810515859307960866
    /// 70172427121883998797908792274921901699720888093776
    /// 65727333001053367881220235421809751254540594752243
    /// 52584907711670556013604839586446706324415722155397
    /// 53697817977846174064955149290862569321978468622482
    /// 83972241375657056057490261407972968652414535100474
    /// 82166370484403199890008895243450658541227588666881
    /// 16427171479924442928230863465674813919123162824586
    /// 17866458359124566529476545682848912883142607690042
    /// 24219022671055626321111109370544217506941658960408
    /// 07198403850962455444362981230987879927244284909188
    /// 84580156166097919133875499200524063689912560717606
    /// 05886116467109405077541002256983155200055935729725
    /// 71636269561882670428252483600823257530420752963450
    /// Answer: 
    /// </summary>
    public class Problem8
    {
        public static int Solve()
        {
            const int numPerSide = 4;
            int numDigits = 2;
            int[,] arr = new int[numPerSide, numPerSide] { { 6, 7, 9, 3 }, { 5, 4, 7, 2 }, { 1, 3, 5, 2 }, { 7, 8, 1, 4 } };

            int maxRowProduct = GetMaxRowProduct(arr, numPerSide, numDigits);
            int maxColumnProduct = GetMaxColumnProduct(arr, numPerSide, numDigits);
            int maxLowerRightDiagonalProduct = GetMaxLowerRightDiagonalProduct(arr, numPerSide, numDigits);
            int maxLowerLeftDiagonalProduct = GetMaxLowerLeftDiagonalProduct(arr, numPerSide, numDigits);
            
            return Math.Max(Math.Max(maxRowProduct, maxColumnProduct), Math.Max(maxLowerRightDiagonalProduct, maxLowerLeftDiagonalProduct));
        }

        /// <summary>
        /// For a given 2D square matrix, method determines the maximum lower-left diagonal product for a given number of 
        /// consecutive digits.
        /// </summary>
        /// <param name="arr">2D square matrix.</param>
        /// <param name="numPerSide">Number of digits per side in the 2D square matrix.</param>
        /// <param name="numDigits">Number of consecutive digits to calculate the product from.</param>
        /// <returns>Maximum product.</returns>
        private static int GetMaxLowerLeftDiagonalProduct(int[,] arr, int numPerSide, int numDigits)
        {
            int maxProduct = 0;

            for (int row = 0; row <= numPerSide - numDigits; row++)
            {
                for (int column = 1; column < numPerSide; column++)
                {
                    int product = 1;
                    for (int digitIndex = 0; digitIndex < numDigits; digitIndex++)
                    {
                        product *= arr[row + digitIndex, column - digitIndex];
                    }
                    if (product > maxProduct)
                    {
                        maxProduct = product;
                    }
                }
            }

            return maxProduct;
        }

        /// <summary>
        /// For a given 2D square matrix, method determines the maximum lower-right diagonal product for a given number of 
        /// consecutive digits.
        /// </summary>
        /// <param name="arr">2D square matrix.</param>
        /// <param name="numPerSide">Number of digits per side in the 2D square matrix.</param>
        /// <param name="numDigits">Number of consecutive digits to calculate the product from.</param>
        /// <returns>Maximum product.</returns>
        private static int GetMaxLowerRightDiagonalProduct(int[,] arr, int numPerSide, int numDigits)
        {
            int maxProduct = 0;

            for (int row = 0; row <= numPerSide - numDigits; row++)
            {
                for (int column = 0; column <= numPerSide - numDigits; column++)
                {
                    int product = 1;
                    for (int digitIndex = 0; digitIndex < numDigits; digitIndex++)
                    {
                        product *= arr[row + digitIndex, column + digitIndex];
                    }
                    if (product > maxProduct)
                    {
                        maxProduct = product;
                    }
                }
            }

            return maxProduct;
        }

        /// <summary>
        /// For a given 2D square matrix, method determines the maximum column product for a given number of 
        /// consecutive digits.
        /// </summary>
        /// <param name="arr">2D square matrix.</param>
        /// <param name="numPerSide">Number of digits per side in the 2D square matrix.</param>
        /// <param name="numDigits">Number of consecutive digits to calculate the product from.</param>
        /// <returns>Maximum product.</returns>
        private static int GetMaxColumnProduct(int[,] arr, int numPerSide, int numDigits)
        {
            int maxProduct = 0;

            for (int row = 0; row <= numPerSide - numDigits; row++)
            {
                for (int column = 0; column < numPerSide; column++)
                {
                    int product = 1;
                    for (int digitIndex = 0; digitIndex < numDigits; digitIndex++)
                    {
                        product *= arr[row + digitIndex, column];
                    }
                    if (product > maxProduct)
                    {
                        maxProduct = product;
                    }
                }
            }

            return maxProduct;
        }

        /// <summary>
        /// For a given 2D square matrix, method determines the maximum row product for a given number of 
        /// consecutive digits.
        /// </summary>
        /// <param name="arr">2D square matrix.</param>
        /// <param name="numPerSide">Number of digits per side in the 2D square matrix.</param>
        /// <param name="numDigits">Number of consecutive digits to calculate the product from.</param>
        /// <returns>Maximum product.</returns>
        private static int GetMaxRowProduct(int[,] arr, int numPerSide, int numDigits)
        {
            int maxProduct = 0;

            for (int row = 0; row < numPerSide; row++)
            {
                for (int col = 0; col <= numPerSide - numDigits; col++)
                {
                    int product = 1;
                    for (int digitIndex = 0; digitIndex < numDigits; digitIndex++)
                    {
                        product *= arr[row, col + digitIndex];
                    }
                    if (product > maxProduct)
                    {
                        maxProduct = product;
                    }
                }
            }

            return maxProduct;
        }
    }
}
