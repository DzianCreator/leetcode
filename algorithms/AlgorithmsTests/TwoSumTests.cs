using TwoSum;

namespace AlgorithmsTests
{
	public class TwoSumTests
	{
		[Theory]
		[InlineData(new int[] { }, 0)]
		[InlineData(new int[] { 1, 2, 3 }, 7)]
		public void NoValidSolution_ReturnEmptyArray(int[] nums, int target)
		{
			var result = Calculation.TwoSum(nums, target);
			Assert.Empty(result);
		}

		[Theory]
		[InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
		[InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
		[InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
		[InlineData(new int[] { 1, 3, 7, 11, 27}, 14, new int[] { 1, 3 })]
		public void PositiveNumbers_FindCorrectIndices(int[] nums, int target, int[] expected)
		{
			var result = Calculation.TwoSum(nums, target);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(new int[] { -2, -7, -11, -15 }, -9, new int[] { 0, 1 })]
		[InlineData(new int[] { -3, -2, -4 }, -6, new int[] { 1, 2 })]
		[InlineData(new int[] { -3, -3 }, -6, new int[] { 0, 1 })]
		[InlineData(new int[] { -1, -3, -7, -11, -27 }, -14, new int[] { 1, 3 })]
		public void NegativeNumbers_FindsCorrectIndices(int[] nums, int target, int[] expected)
		{
			var result = Calculation.TwoSum(nums, target);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(new int[] { -3, -7, 11, 15, 0, -4, 7, 0, 11 }, 0, new int[] { 1, 6 })]
		[InlineData(new int[] { 7, 4, -1, -12, 3, 15 }, 6, new int[] { 0, 2 })]
		[InlineData(new int[] { -6, -7, 4, 13, 7, -3 }, 0, new int[] { 1, 4 })]
		public void MixedNumbers_FindsCorrectIndices(int[] nums, int target, int[] expected)
		{
			var result = Calculation.TwoSum(nums, target);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(new int[] { 1000000, 500000, 1500000 }, 2500000, new int[] { 0, 2 })]
		[InlineData(new int[] { 0, 500000000, 0, 1, 500000000 }, 1000000000, new int[] { 1, 4 })]
		public void LargeNumbers_FindsCorrectIndices(int[] nums, int target, int[] expected)
		{
			var result = Calculation.TwoSum(nums, target);
			Assert.Equal(expected, result);
		}
	}
}