
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
			for (int i = 0; i < nums.Length && nums[i] <= 0; ++i)
			{
				if (i - 1 >= 0)
				{
					if (nums[i] == nums[i - 1])
					{
						continue;
					}
				}
				HashSet<int> candidates = [];
				for (int j = i + 1; j < nums.Length; ++j)
				{
					if (j - 2 >= i + 1)
					{
						if (nums[j] == nums[j - 2])
						{
							continue;
						}
					}
					int candidate = -nums[j];
					if (candidates.Contains(candidate))
					{
						results.Add([nums[i], -nums[i] - nums[j], nums[j]]);
						candidates.Remove(candidate);
					}
					else
					{
						candidates.Add(nums[j] + nums[i]);
					}
				}
			}
			return results;
		}
	}
}
