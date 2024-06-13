using Algorithms;

namespace AlgorithmsTests
{
	public class ValidParenthesesTests
	{
		[Fact]
		public void EmptyString_Return0()
		{
			var result = ValidParentheses.Calculate("");
			Assert.False(result);
		}

		[Theory]
		[InlineData("(")]
		[InlineData(")")]
		[InlineData(")(")]
		[InlineData("))(((")]
		[InlineData("(}")]
		[InlineData("(]")]
		[InlineData("{]")]
		[InlineData("{)")]
		[InlineData("[)")]
		[InlineData("[}")]
		public void InvalidString_ReturnFalse(string s)
		{
			var result = ValidParentheses.Calculate(s);
			Assert.False(result);
		}

		[Theory]
		[InlineData("(()")]
		[InlineData(")()")]
		[InlineData("())")]
		[InlineData("()(")]
		[InlineData(")()())")]
		[InlineData("()(()")]
		[InlineData("())()")]
		[InlineData("()((())")]
		[InlineData("())(())")]
		[InlineData("((())())))")]
		[InlineData("()(())())")]
		[InlineData("(()(())()")]
		[InlineData("(()))(()()())")]
		[InlineData("(()(((()")]
		[InlineData("()(()){)")]
		[InlineData("((())]")]
		[InlineData("(([))())")]
		[InlineData("((()()())[)()(()))()")]
		public void PartlyValid_ReturnFalse(string s)
		{
			var result = ValidParentheses.Calculate(s);
			Assert.False(result);
		}

		[Theory]
		[InlineData("()(())()")]
		[InlineData("((()))")]
		[InlineData("((())())")]
		[InlineData("((()()())()()(()))()")]
		[InlineData("()([()])()")]
		[InlineData("(({({})}))[]")]
		[InlineData("{((())([]))}")]
		[InlineData("((()([])([]))([])()((){})){}()")]
		[InlineData("()(({}))([])")]
		[InlineData("[[]]{}(){}")]
		[InlineData("{{}}{}[]((){})")]
		[InlineData("{[(([](){})[]{}({}))()][{}][()]}")]
		public void FullyValid_ReturnLength(string s)
		{
			var result = ValidParentheses.Calculate(s);
			Assert.True(result);
		}
	}
}
