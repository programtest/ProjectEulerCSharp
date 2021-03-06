﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEulerLibrary;

namespace ProjectEuler
{
    /// <summary>
    /// Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
    /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    /// Answer: 4613732
    /// </summary>
    public class Problem2
    {
        public static int Solve()
        {
            // Get Fibonacci numbers less than 4 million.
            List<int> fibonacciNums = Mathematics.GetFibonacciNums(4000000);

            int sum = 0;
            foreach (int num in fibonacciNums)
            {
                // If the number is even.
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}
