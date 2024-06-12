using Algorithms;

namespace AlgorithmsTests
{
	public class LongestValidParenthesesTests
	{
		[Fact]
		public void EmptyString_Return0()
		{
			var result = LongestValidParentheses.Calculate("");
			Assert.Equal(0, result);
		}

		[Theory]
		[InlineData("(")]
		[InlineData(")")]
		[InlineData(")(")]
		[InlineData("))(((")]
		public void InvalidString_Return0(string s)
		{
			var result = LongestValidParentheses.Calculate(s);
			Assert.Equal(0, result);
		}

		[Theory]
		[InlineData("(()", 2)]
		[InlineData(")()", 2)]
		[InlineData("())", 2)]
		[InlineData("()(", 2)]
		[InlineData(")()())", 4)]
		[InlineData("()(()", 2)]
		[InlineData("())()", 2)]
		[InlineData("()((())", 4)]
		[InlineData("())(())", 4)]
		[InlineData("((())())))", 8)]
		[InlineData("()(())())", 8)]
		[InlineData("(()(())()", 8)]
		[InlineData("(()))(()()())", 8)]
		[InlineData("(()(((()", 2)]
		public void PartlyValid_ReturnLength(string s, int expected)
		{
			var result = LongestValidParentheses.Calculate(s);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData("()(())()", 8)]
		[InlineData("((()))", 6)]
		[InlineData("((())())", 8)]
		[InlineData("((()()())()()(()))()", 20)]
		public void FullyValid_ReturnLength(string s, int expected)
		{
			var result = LongestValidParentheses.Calculate(s);
			Assert.Equal(expected, result);
		}
	}
}
