using Algorithms;

namespace AlgorithmsTests
{
	public class MedianOfTwoSortedArraysTests
	{
		[Fact]
		public void BothEmpty_ReturnZero()
		{
			var result = MedianOfTwoSortedArrays.Calculate(null, null);
			Assert.Equal(0, result);
		}

		[Theory]
		[InlineData(new int[] { 2, 4, 6, 7, 8, 9 }, 6.5)]
		[InlineData(new int[] { 1, 4, 7 }, 4)]
		[InlineData(new int[] { 5 }, 5)]
		public void FirstEmpty_ReturnMedian(int[] nums, double expected)
		{
			var result = MedianOfTwoSortedArrays.Calculate(null, nums);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(new int[] { 1, 9, 10, 13, 17, 19 }, 11.5)]
		[InlineData(new int[] { 1, 999, 1000 }, 999)]
		[InlineData(new int[] { 3 }, 3)]
		public void SecondEmpty_ReturnMedian(int[] nums, double expected)
		{
			var result = MedianOfTwoSortedArrays.Calculate(nums, null);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(new int[] { 5, 9, 10 }, new int[] { 7, 11 }, 9)]
		[InlineData(new int[] { 2, 3 }, new int[] { 4, 5, 6 }, 4)]
		[InlineData(new int[] { 2, 3, 5, 6 }, new int[] { 4 }, 4)]
		[InlineData(new int[] { 2, 3, 6 }, new int[] { 4, 5 }, 4)]
		[InlineData(new int[] { 4 }, new int[] { 2, 3, 5, 6 }, 4)]
		[InlineData(new int[] { 4, 5 }, new int[] { 2, 3, 6 }, 4)]
		[InlineData(new int[] { 4, 5, 6 }, new int[] { 2, 3 }, 4)]
		[InlineData(new int[] { 2, 3, 4, 5 }, new int[] { 6, 7 }, 4.5)]
		[InlineData(new int[] { 3, 4, 5 }, new int[] { 2, 6, 7 }, 4.5)]
		[InlineData(new int[] { 4, 5 }, new int[] { 2, 3, 6, 7 }, 4.5)]
		[InlineData(new int[] { 6, 7 }, new int[] { 2, 3, 4, 5 }, 4.5)]
		[InlineData(new int[] { 2, 6, 7 }, new int[] { 3, 4, 5 }, 4.5)]
		[InlineData(new int[] { 2, 3, 6, 7 }, new int[] { 4, 5 }, 4.5)]
		public void MedianInOneArray_ReturnMedian(int[] nums1, int[] nums2, double expected)
		{
			var result = MedianOfTwoSortedArrays.Calculate(nums1, nums2);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(new int[] { 1 }, new int[] { 1 }, 1)]
		[InlineData(new int[] { 1 }, new int[] { 2 }, 1.5)]
		[InlineData(new int[] { 1, 2 }, new int[] { 2, 3 }, 2)]
		[InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
		[InlineData(new int[] { 1, 4, 5 }, new int[] { 2, 3, 6 }, 3.5)]
		[InlineData(new int[] { 1, 2 }, new int[] { 1, 1, 2, 2 }, 1.5)]
		public void MedianBetweenArrays_ReturnMedian(int[] nums1, int[] nums2, double expected)
		{
			var result = MedianOfTwoSortedArrays.Calculate(nums1, nums2);
			Assert.Equal(expected, result);
		}
	}
}
