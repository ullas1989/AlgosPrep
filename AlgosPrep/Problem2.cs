using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosPrep
{
    public class Problem2
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int seqIdx = 0;

            foreach(var val in array)
            {
                if(seqIdx == sequence.Count)
                {
                    break;
                }

                if (sequence[seqIdx] == val)
                {
                    seqIdx++;
                }
            }

            return seqIdx == sequence.Count;
        }
    }
}
