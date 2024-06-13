using Algorithms;

namespace AlgorithmsTests
{
	public class LongestCommonPrefixTests
	{
		[Fact]
		public void EmptyArray_ReturnEmptyString()
		{
			string result = LongestCommonPrefix.Calculate(new string[0]);
			Assert.Equal("", result);
		}

		[Fact]
		public void AllStringsWithPrefix1_ReturnPrefix()
		{
			string[] strs = { "flower", "flow", "flight" };
			string result = LongestCommonPrefix.Calculate(strs);
			Assert.Equal("fl", result);
		}

		[Fact]
		public void AllStringsWithPrefix2_ReturnPrefix()
		{
			string[] strs = { "abcdef", "abcd", "abcdefjh", "abcdefj", "abcdklm" };
			string result = LongestCommonPrefix.Calculate(strs);
			Assert.Equal("abcd", result);
		}

		[Fact]
		public void AllStringsWithPrefix3_ReturnPrefix()
		{
			string[] strs = { "abcde", "abcdfg", "abcdop", "abcdrml", "abcdfgh", "abcderml", "abcdrmlef" };
			string result = LongestCommonPrefix.Calculate(strs);
			Assert.Equal("abcd", result);
		}

		[Fact]
		public void OnString_ReturnString()
		{
			string[] strs = { "abcd" };
			string result = LongestCommonPrefix.Calculate(strs);
			Assert.Equal("abcd", result);
		}

		[Fact]
		public void SomeStringsWithPrefix_ReturnEmptyString()
		{
			string[] strs = { "cat", "bcde", "cfde", "rat", "", "abcd", "acde", "bcfe", "cfda", "set" };
			string result = LongestCommonPrefix.Calculate(strs);
			Assert.Equal("", result);
		}

		[Fact]
		public void MultipleStringsNoPrefix_ReturnEmptyString()
		{
			string[] strs = { "dog", "racecar", "car" };
			string result = LongestCommonPrefix.Calculate(strs);
			Assert.Equal("", result);
		}

		[Fact]
		public void EqualStrings_ReturnPrefix()
		{
			string[] strs = { "abcde", "abcde", "abcde" };
			string result = LongestCommonPrefix.Calculate(strs);
			Assert.Equal("abcde", result);
		}
	}
}
