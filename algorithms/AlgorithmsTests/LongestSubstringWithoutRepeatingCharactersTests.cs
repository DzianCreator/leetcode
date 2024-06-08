using Algorithms;

namespace AlgorithmsTests
{
	public class LongestSubstringWithoutRepeatingCharactersTests
	{
		[Theory]
		[InlineData((string)null)]
		[InlineData("")]
		public void NullOrEmpty_ReturnZero(string s)
		{
			var result = LongestSubstringWithoutRepeatingCharacters.Calculate(s);
			Assert.Equal(0, result);
		}

		[Theory]
		[InlineData("abcabcbb", 3)]
		[InlineData("bbbbb", 1)]
		[InlineData("pwwkew", 3)]
		[InlineData("aab", 2)]
		[InlineData("abcbkklmmklmr", 4)]
		[InlineData("abcdeffytcccyadaysty", 6)]
		[InlineData("abababab", 2)]
		[InlineData("abcabcabcabc", 3)]
		[InlineData("ababababbabab", 2)]
		public void String_ReturnLength(string s, int expected)
		{
			var result = LongestSubstringWithoutRepeatingCharacters.Calculate(s);
			Assert.Equal(expected, result);
		}
	}
}
