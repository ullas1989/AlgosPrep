using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosPrep
{
    public class Problem3
    {
        public int[] SortedSquaredArray(int[] array)
        {
            int[] result = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] * array[i];
            }

            Array.Sort(result);

            return result;
        }

        public int[] SortedSquaredArraySoln2(int[] array)
        {
            int[] result = new int[array.Length];

            int smallerValueIdx = 0;
            int largerValueIdx = array.Length - 1;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                int smallerValue = array[smallerValueIdx];
                int largerValue = array[largerValueIdx];

                if (Math.Abs(smallerValue) > Math.Abs(largerValue))
                {
                    result[i] = smallerValue * smallerValue;
                    smallerValueIdx++;
                }
                else
                {
                    result[i] = largerValue * largerValue;
                    largerValueIdx--;
                }
            }

            return result;
        }
    }
}
