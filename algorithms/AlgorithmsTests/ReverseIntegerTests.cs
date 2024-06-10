using Algorithms;

namespace AlgorithmsTests
{
	public class ReverseIntegerTests
	{
		[Theory]
		[InlineData(0)]
		[InlineData(1)]
		[InlineData(5)]
		[InlineData(9)]
		public void OneDigit_ReturnReverse(int x)
		{
			var result = ReverseInteger.Calculate(x);
			Assert.Equal(x, result);
		}

		[Theory]
		[InlineData(10, 1)]
		[InlineData(1000, 1)]
		[InlineData(1234, 4321)]
		[InlineData(1221, 1221)]
		[InlineData(-1000, -1)]
		[InlineData(-1234, -4321)]
		public void SmallNumber_ReturnReverse(int x, int expected)
		{
			var result = ReverseInteger.Calculate(x);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(Int32.MaxValue, 0)]
		[InlineData(Int32.MinValue, 0)]
		public void OverflowingNumber_ReturnReverse(int x, int expected)
		{
			var result = ReverseInteger.Calculate(x);
			Assert.Equal(expected, result);
		}
	}
}
