using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEulerLibrary;

namespace ProjectEuler
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// Answer: 232792560
    /// </summary>
    public class Problem5
    {
        public static int Solve()
        {
            return Mathematics.GetLeastCommonMultiple(new List<int>() { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });
        }
    }
}
