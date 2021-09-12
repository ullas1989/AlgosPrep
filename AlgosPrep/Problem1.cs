using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosPrep
{
    public class Problem1
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            List<int> nums = new List<int>();

            // Write your code here.
            foreach(var num in array)
            {
                var pMatch = targetSum - num;

                if (nums.Contains(pMatch))
                {
                    return new int[] { pMatch, num };
                }
                else
                {
                    nums.Add(num);
                }
            }

            return new int[0];
        }
    }
}
