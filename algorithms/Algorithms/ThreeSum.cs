
namespace Algorithms
{
	public class ThreeSum
	{
		public static IList<IList<int>> Calculate(int[] nums)
		{
			IList<IList<int>> results = [];
			if (nums == null || nums.Length < 3)
			{
				return results;
			}
			Array.Sort(nums);
			for (int i = 0; i < nums.Length && nums[i] < 1; ++i)
			{
				if (i > 0 && nums[i] == nums[i - 1])
				{
					continue;
				}
				int j = i + 1;
				int k = nums.Length - 1;
				while (j < k)
				{
					int sum = nums[i] + nums[j] + nums[k];
					if (sum == 0)
					{
						results.Add([nums[i], nums[j], nums[k]]);
						while (j < k && nums[j + 1] == nums[j])
						{
							j++;
						}
						j++;
					}
					else if (sum < 0)
					{
						while (j < k && nums[j + 1] == nums[j])
						{
							j++;
						}
						j++;
					}
					else
					{
						while (k > j && nums[k - 1] == nums[k])
						{
							k--;
						}
						k--;
					}
				}
			}
			return results;
		}
	}
}
