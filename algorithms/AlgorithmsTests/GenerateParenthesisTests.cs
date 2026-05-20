using Algorithms;

namespace AlgorithmsTests
{
	public class GenerateParenthesisTests
	{
		[Fact]
		public void Zero_ReturnEmptyArray()
		{
			var result = GenerateParenthesis.Generate(0);
			Assert.Empty(result);
		}

		[Fact]
		public void One_ReturnString()
		{
			var result = GenerateParenthesis.Generate(1);
			Assert.Single(result);
			Assert.Equal("()", result[0]);
		}

		[Fact]
		public void Two_ReturnArray()
		{
			var result = GenerateParenthesis.Generate(2);
			Assert.Equal(2, result.Count);
			Assert.Contains("(())", result);
			Assert.Contains("()()", result);
		}

		[Fact]
		public void Three_ReturnArray()
		{
			var result = GenerateParenthesis.Generate(3);
			Assert.Equal(5, result.Count);
			Assert.Contains("((()))", result);
			Assert.Contains("(()())", result);
			Assert.Contains("(())()", result);
			Assert.Contains("()(())", result);
			Assert.Contains("()()()", result);
		}
	}
}
