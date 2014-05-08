using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEulerLibrary;

namespace ProjectEuler
{
    /// <summary>
    /// The following iterative sequence is defined for the set of positive integers:
    /// n → n/2 (n is even)
    /// n → 3n + 1 (n is odd)
    /// Using the rule above and starting with 13, we generate the following sequence:
    /// 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
    /// It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
    /// Which starting number, under one million, produces the longest chain?
    /// NOTE: Once the chain starts the terms are allowed to go above one million.
    /// Answer: 
    /// </summary>
    public class Problem14
    {
        public static int Solve()
        {
            Dictionary<int, int> sequenceLengthByStartingValue = new Dictionary<int, int>();
            sequenceLengthByStartingValue.Add(1, 1);

            int longestSequenceLength = 1;
            int longestSequenceStartingNum = 1;

            for (int i = 2; i < 100000; i++)
            {
                ReverseLinkedList reverseLinkedList = new ReverseLinkedList();
                // If dictionary already contains starting value, just move on since you know that the sequence
                // length is already accounted for.
                if (sequenceLengthByStartingValue.ContainsKey(i))
                {
                    continue;
                }

                int current = i;

                while (true)
                {
                    reverseLinkedList.Add(current);
                    if (Mathematics.IsEven(current))
                    {
                        current /= 2;
                    }
                    else
                    {
                        current = 3 * current + 1;
                    }
                    // If current is in dictionary.
                    if (sequenceLengthByStartingValue.ContainsKey(current))
                    {
                        // Get current's associated value in the dictionary.
                        int currentValue = sequenceLengthByStartingValue[current];
                        List<int> linkedListValues = reverseLinkedList.Traverse();
                        int count = 1;
                        // Loop through list of values.
                        foreach (int linkedListValue in linkedListValues)
                        {
                            if (!sequenceLengthByStartingValue.ContainsKey(linkedListValue))
                            {
                                sequenceLengthByStartingValue.Add(linkedListValue, count + currentValue);
                            }
                            count++;
                        }
                        // If count for list of values + current's value in dictionary is greater than longest sequence,
                        // set longest sequence to this value.
                        int sequenceLength = linkedListValues.Count + currentValue;
                        if (sequenceLength > longestSequenceLength)
                        {
                            longestSequenceLength = sequenceLength;
                            longestSequenceStartingNum = i;
                        }

                        break;
                    }
                }
            }
            return longestSequenceStartingNum;
        }
    }
}
