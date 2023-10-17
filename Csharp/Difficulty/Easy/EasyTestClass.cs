using Xunit;

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

    [Theory]
    [InlineData("Hello", "Holle")]
    [InlineData("leetcode", "leotcede")]
    [InlineData("aA", "Aa")]
    public void ReverseVowelsOfAStringTest(string inputStr, string expectedStr){

        string result = Easy.ReverseVowelsOfAString.ReverseVowels(inputStr);
        Assert.Equal(expectedStr, result);
    }
}
