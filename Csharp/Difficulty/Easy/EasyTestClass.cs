using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;


namespace Csharp.Difficulty.Easy
{
    public class TwoSumTest
    {
        [Theory]
        [InlineData(new int[]{2,7,11,15}, 9, new int[]{1,0})]
        [InlineData(new int[]{3, 2, 4}, 6, new int[]{2, 1})]
        [InlineData(new int[]{3,3}, 6, new int[]{1,0})]

        public void TwoSumStandardInput(int[] arr, int target, int[] expected)
        {
            int[] result = Easy.TwoSum.Solution(arr, target);
            Assert.Equal(expected, result);
        }
    }
}