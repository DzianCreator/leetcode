
namespace Algorithms
{
	public class MedianOfTwoSortedArrays
	{
		public static double Calculate(int[] nums1, int[] nums2)
		{
			nums1 ??= [];
			nums2 ??= [];
			if (nums1.Length == 0 && nums2.Length == 0)
			{
				return 0;
			}
			int[] nums = [];
			if (nums1.Length == 0)
			{
				nums = nums2;
			}
			if (nums2.Length == 0)
			{
				nums = nums1;
			}
			if (nums.Length != 0)
			{
				int index = nums.Length / 2;
				if (nums.Length % 2 == 0)
				{
					return (double)(nums[index] + nums[index - 1]) / 2;
				}
				else
				{
					return nums[index];
				}
			}
			int i1 = 0;
			int i2 = 0;
			int prevNumber = 0;
			int medianNumber = 0;
			int medianIndex = (nums1.Length + nums2.Length) / 2;
			int sequentialIndex = 0;
			while (sequentialIndex <= medianIndex)
			{
				if (i1 == nums1.Length)
				{
					prevNumber = medianNumber;
					medianNumber = nums2[i2];
					i2++;
				}
				else if (i2 == nums2.Length)
				{
					prevNumber = medianNumber;
					medianNumber = nums1[i1];
					i1++;
				}
				else
				{
					if (nums1[i1] > nums2[i2])
					{
						prevNumber = medianNumber;
						medianNumber = nums2[i2];
						i2++;
					}
					else
					{
						prevNumber = medianNumber;
						medianNumber = nums1[i1];
						i1++;
					}
				}
				sequentialIndex++;
			}
			if ((nums1.Length + nums2.Length) % 2 == 0)
			{
				return (double)(prevNumber + medianNumber) / 2;
			}
			else
			{
				return medianNumber;
			}
		}
	}
}
