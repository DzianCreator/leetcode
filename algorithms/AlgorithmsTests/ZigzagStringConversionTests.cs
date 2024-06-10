using Algorithms;
namespace AlgorithmsTests
{
	public class ZigzagStringConversionTests
	{
		[Fact]
		public void NullString_ReturnEmptyString()
		{
			string result = ZigzagStringConversion.Calculate(null, 1);
			Assert.Equal(string.Empty, result);
		}

		[Theory]
		[InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
		[InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
		[InlineData("babad", 2, "bbdaa")]
		[InlineData("acbrbca", 1, "acbrbca")]
		[InlineData("a", 2, "a")]
		[InlineData("ptrtt", 5, "ptrtt")]
		[InlineData("ptrtt", 10, "ptrtt")]
		[InlineData("ptrtt", 4, "ptrtt")]
		[InlineData("abcde", 4, "abced")]
		public void String_ReturnConverted(string input, int numRows, string expected)
		{
			string result = ZigzagStringConversion.Calculate(input, numRows);
			Assert.Equal(expected, result);
		}
	}
}
