using System;
using Xunit;

namespace AlgosPrep.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Problem1Test()
        {
            var array = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            var targetSum = 10;
            var output = new int[] { -1, 11 };

            var result = Problem1.TwoNumberSum(array, targetSum);

            Array.Sort(output);
            Array.Sort(result);

            Assert.Equal(output, result);
        }
    }
}
