using Algorithms;

namespace AlgorithmsTests
{
	public class StringToIntegerAtoiTests
	{
		[Fact]
		public void NullString_Return0()
		{
			int result = StringToIntegerAtoi.Calculate(null);
			Assert.Equal(0, result);
		}

		[Fact]
		public void EmptyString_Return0()
		{
			int result = StringToIntegerAtoi.Calculate(string.Empty);
			Assert.Equal(0, result);
		}

		[Theory]
		[InlineData("42", 42)]
		[InlineData("54321", 54321)]
		[InlineData("912", 912)]
		[InlineData("-6432", -6432)]
		public void NumberString_ReturnNumber(string s, int expected)
		{
			int result = StringToIntegerAtoi.Calculate(s);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData("-0", 0)]
		[InlineData("0", 0)]
		[InlineData("-00042", -42)]
		[InlineData("000230", 230)]
		public void LeadingZero_ReturnNumber(string s, int expected)
		{
			int result = StringToIntegerAtoi.Calculate(s);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData("-0asdf", 0)]
		[InlineData("0fdsa", 0)]
		[InlineData("-42d", -42)]
		[InlineData("000230asd", 230)]
		public void StringEndsWithNonDigits_ReturnNumber(string s, int expected)
		{
			int result = StringToIntegerAtoi.Calculate(s);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData("-0-1", 0)]
		[InlineData("0-1", 0)]
		[InlineData("-42d234", -42)]
		[InlineData("000230-3", 230)]
		public void StringWithManyDigits_ReturnNumber(string s, int expected)
		{
			int result = StringToIntegerAtoi.Calculate(s);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData("-d0-1", 0)]
		[InlineData("tre0-1", 0)]
		[InlineData("-fdsa42d234", 0)]
		[InlineData("d000230-3", 0)]
		public void StringStartsWithNonDigits_ReturnNumber(string s, int expected)
		{
			int result = StringToIntegerAtoi.Calculate(s);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData("-", 0)]
		[InlineData("--", 0)]
		[InlineData("-+", 0)]
		[InlineData("+", 0)]
		public void IncompliteNumber_ReturnNumber(string s, int expected)
		{
			int result = StringToIntegerAtoi.Calculate(s);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData("2222222222222222", Int32.MaxValue)]
		[InlineData("-23232323232323232323", Int32.MinValue)]
		[InlineData("2147483648", Int32.MaxValue)]
		[InlineData("-2147483649", Int32.MinValue)]
		public void OverflowingNumber_ReturnNumber(string s, int expected)
		{
			int result = StringToIntegerAtoi.Calculate(s);
			Assert.Equal(expected, result);
		}
	}
}
