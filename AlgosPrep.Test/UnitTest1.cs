using System;
using System.Linq;
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
        [Fact]
        public void Problem2Test()
        {
            var array = new int[] { 5, 1, 22, 25, 6, -1, 8, 10 };
            var sequence = new int[] { 1, 6, -1, 10 };

            var result = Problem2.IsValidSubsequence(array.ToList(), sequence.ToList());

            Assert.True(result);
        }
        [Fact]
        public void Problem3Test()
        {
            var p3 = new Problem3();

            var array = new int[] { 1, 2, 3, 5, 6, 8, 9 };
            var output = new int[] { 1, 4, 9, 25, 36, 64, 81 };

            var result = p3.SortedSquaredArraySoln2(array);

            Assert.Equal(output, result);
        }
    }
}
