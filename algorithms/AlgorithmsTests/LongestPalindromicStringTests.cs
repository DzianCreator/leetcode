using Algorithms;

namespace AlgorithmsTests
{
	public class LongestPalindromicStringTests
	{
		[Fact]
		public void NullString_ReturnEmptyString()
		{
			string result = LongestPalindromicString.Calculate(null);
			Assert.Equal(string.Empty, result);
		}

		[Theory]
		[InlineData("babad", "bab")]
		[InlineData("acbrbca", "acbrbca")]
		[InlineData("a", "a")]
		[InlineData("", "")]
		[InlineData("ptrttrtabcecbatattatc", "tabcecbat")]
		[InlineData("abcdcb", "bcdcb")]
		[InlineData("bcdcba", "bcdcb")]
		public void StringWithLongestOddPalindrome_ReturnPalindrome(string input, string expected)
		{
			string result = LongestPalindromicString.Calculate(input);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData("bb", "bb")]
		[InlineData("abbc", "bb")]
		[InlineData("abb", "bb")]
		[InlineData("bbbba", "bbbb")]
		[InlineData("adtcbbctdtatdtatyuo", "dtcbbctd")]
		public void StringWithLongestEvenPalindrome_ReturnPalindrome(string input, string expected)
		{
			string result = LongestPalindromicString.Calculate(input);
			Assert.Equal(expected, result);
		}
	}
}
