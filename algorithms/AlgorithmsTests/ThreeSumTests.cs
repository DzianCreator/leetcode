using Algorithms;

namespace AlgorithmsTests
{
	public class ThreeSumTests
	{
		[Fact]
		public void EmptyArray_ReturnEmptyArray()
		{
			var result = ThreeSum.Calculate([]);
			Assert.Empty(result);
		}

		[Fact]
		public void LessThen3Array_ReturnEmptyArray()
		{
			var result = ThreeSum.Calculate([1, 2]);
			Assert.Empty(result);
		}

		[Fact]
		public void NoTriplets1_ReturnEmptyArray()
		{
			var result = ThreeSum.Calculate([0,1,1]);
			Assert.Empty(result);
		}

		[Fact]
		public void NoTriplet2_ReturnEmptyArray()
		{
			var result = ThreeSum.Calculate([-1, 0, 2, 5, -3]);
			Assert.Empty(result);
		}

		[Fact]
		public void NoTriplet3_ReturnEmptyArray()
		{
			var result = ThreeSum.Calculate([1, -2, 2, 5, 10, -10, 3, 17]);
			Assert.Empty(result);
		}

		[Fact]
		public void NoTriplet4_ReturnEmptyArray()
		{
			var result = ThreeSum.Calculate([-2, 2, 2, 2, 3, 3, 3, 3]);
			Assert.Empty(result);
		}

		[Fact]
		public void AllZeros_ReturnTriplet()
		{
			var result = ThreeSum.Calculate([0, 0, 0]);
			List<IList<int>> expected = [[0, 0, 0]];
			Assert.Equal(expected, result);
		}

		[Fact]
		public void AllZerosWithDuplicates_ReturnTriplet()
		{
			var result = ThreeSum.Calculate([0, 0, 0, 0, 0, 0, 0]);
			List<IList<int>> expected = [[0, 0, 0]];
			Assert.Equal(expected, result);
		}

		[Fact]
		public void MultipleTriples1_ReturnTriplets()
		{
			var result = ThreeSum.Calculate([0, 0, -1, 1, -2, 2, 3]);
			List<IList<int>> expected = [[-1, 0, 1], [-2, 0, 2], [-2, -1, 3]];
			Assert.Equal(expected.Count, result.Count);
			for (int i = 0; i < expected.Count; ++i)
			{
				bool hasExpected = false;
				for (int j = 0; j < result.Count; ++j)
				{
					int[] sorted = result[j].OrderBy(t => t).ToArray();
					bool accepted = true;
					for (int k = 0; k < sorted.Count(); ++k)
					{
						if (expected[i][k] != sorted[k])
						{
							accepted = false;
							break;
						}
					}
					if (accepted)
					{
						hasExpected = true;
						break;
					}
				}
				Assert.True(hasExpected);
			}
		}

		[Fact]
		public void MultipleTriples2_ReturnTriplets()
		{
			var result = ThreeSum.Calculate([-1, 0, 1, 2, -1, -4]);
			List<IList<int>> expected = [[-1, -1, 2], [-1, 0, 1]];
			Assert.Equal(expected.Count, result.Count);
			for (int i = 0; i < expected.Count; ++i)
			{
				bool hasExpected = false;
				for (int j = 0; j < result.Count; ++j)
				{
					int[] sorted = result[j].OrderBy(t => t).ToArray();
					bool accepted = true;
					for (int k = 0; k < sorted.Count(); ++k)
					{
						if (expected[i][k] != sorted[k])
						{
							accepted = false;
							break;
						}
					}
					if (accepted)
					{
						hasExpected = true;
						break;
					}
				}
				Assert.True(hasExpected);
			}
		}

		[Fact]
		public void MultipleTriplets3_ReturnTriplets()
		{
			var result = ThreeSum.Calculate([1, -1, -1, 0]);
			List<IList<int>> expected = [[-1, 0, 1]];
			Assert.Equal(expected.Count, result.Count);
			for (int i = 0; i < expected.Count; ++i)
			{
				bool hasExpected = false;
				for (int j = 0; j < result.Count; ++j)
				{
					int[] sorted = result[j].OrderBy(t => t).ToArray();
					bool accepted = true;
					for (int k = 0; k < sorted.Count(); ++k)
					{
						if (expected[i][k] != sorted[k])
						{
							accepted = false;
							break;
						}
					}
					if (accepted)
					{
						hasExpected = true;
						break;
					}
				}
				Assert.True(hasExpected);
			}
		}
	}
}
