﻿using Algorithms;

namespace AlgorithmsTests
{
	public class MaximumXorTests
	{
		[Fact]
		public void EmptyArray_ReturnZero()
		{
			var result = MaximumXor.Calculate([]);
			Assert.Equal(0, result);
		}


		[Fact]
		public void EqualNumbers_ReturnZero()
		{
			var result = MaximumXor.Calculate([5,5,5,5]);
			Assert.Equal(0, result);
		}

		[Theory]
		[InlineData(5)]
		[InlineData(6)]
		public void OneNumber_ReturnNumber(int num)
		{
			var result = MaximumXor.Calculate([num]);
			Assert.Equal(0, result);
		}

		[Theory]
		[InlineData(new int[] { 5, 7, 4 }, 3)]
		[InlineData(new int[] { 8, 9, 10 }, 3)]
		public void SameLength_ReturnNumber(int[] nums, int expected)
		{
			var result = MaximumXor.Calculate(nums);
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(new int[] { 1, 2, 3 }, 3)]
		[InlineData(new int[] { 1, 2, 3, 4, 5 }, 7)]
		[InlineData(new int[] { 10, 20, 30, 40, 50 }, 60)]
		[InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 7)]
		[InlineData(new int[] { 3, 10, 5, 25, 2, 8 }, 28)]
		[InlineData(new int[] { 14, 70, 53, 83, 49, 91, 36, 80, 92, 51, 66, 70 }, 127)]
		[InlineData(new int[] { 15, 10, 2, 14 }, 13)]
		[InlineData(new int[] { 29 , 24, 21, 16, 13, 8, 5, 1}, 29)]
		[InlineData(new int[] { 37710, 70350, 99648, 7015, 65989, 33902, 48893, 85155, 49736, 91159, 5375, 62001, 33372, 29226, 51556, 15147, 75820, 24624, 36356, 42353, 57949, 13978, 19406, 81813, 14288, 77475, 78848, 63955, 98157, 14610, 25890, 72574, 29521, 39004, 97856, 34806, 67287, 28486, 86050, 65045, 65468, 42440, 46378, 90088, 70642, 86668, 13962, 29947, 5379, 43894, 71615, 98157, 3136, 53758, 31213, 95011, 10245, 35928, 47833, 19704, 73482, 74069, 56637, 83442, 22825, 99042, 74219, 23952, 40838, 19438, 5506, 68319, 17152, 59754, 72742, 74444, 96307, 79816, 72543, 70036, 40071, 98662, 98800, 12407, 20953, 580, 34577, 51178, 33028, 98832, 45804, 22924, 16428, 47363, 61681, 3185, 54087, 71685, 18902, 62682, 75496, 85195, 49967, 91173, 72136, 40545, 59109, 75360, 31411, 3938, 56662, 88569, 32877, 80996, 23338, 55889, 19199, 42289, 92685, 68208, 86178, 56175, 15469, 71602, 359, 65, 98482, 30366, 27520, 29095, 3541, 28215, 16398, 59265, 1598, 28651, 52488, 16273, 32606, 46345, 79877, 9373, 85925, 38351, 13095, 13971, 78977, 64066, 35844, 86632, 18645, 68567, 4946, 75769, 69137, 2318, 29870, 65843, 51955, 73662, 93033, 71885, 71130, 95627, 42095, 723, 86787, 50004, 57781, 44414, 94754, 27721, 84254, 82782, 27167, 19930, 98123, 56185, 49642, 96907, 1533, 42158, 81852, 96420, 41480, 81810, 9228, 54436, 46966, 32252, 30762, 73909, 67220, 47036, 96059, 2362, 4157, 55557, 75858, 21957 }, 131059)]
		public void Array_ReturnNumber(int[] nums, int expected)
		{
			var result = MaximumXor.Calculate(nums);
			Assert.Equal(expected, result);
		}
	}
}
