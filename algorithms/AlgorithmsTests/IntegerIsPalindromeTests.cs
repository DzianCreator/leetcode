using Algorithms;

namespace AlgorithmsTests
{
	public class IntegerIsPalindromeTests
	{
		[Theory]
		[InlineData(0)]
		[InlineData(1)]
		[InlineData(5)]
		[InlineData(9)]
		public void OneDigitPalindrome_ReturnTrue(int x)
		{
			bool result = IntegerIsPalindrome.Calculate(x);
			Assert.True(result);
		}

		[Theory]
		[InlineData(11)]
		[InlineData(212)]
		[InlineData(923329)]
		[InlineData(92329)]
		public void Palindrome_ReturnTrue(int x)
		{
			bool result = IntegerIsPalindrome.Calculate(x);
			Assert.True(result);
		}

		[Theory]
		[InlineData(-1)]
		[InlineData(-11)]
		[InlineData(-121)]
		[InlineData(1232)]
		[InlineData(12)]
		[InlineData(9123)]
		public void NotPalindrome_ReturnFalse(int x)
		{
			bool result = IntegerIsPalindrome.Calculate(x);
			Assert.False(result);
		}
	}
}
