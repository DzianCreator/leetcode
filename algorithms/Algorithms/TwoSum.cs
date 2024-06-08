
namespace Algorithms
{
	public class TwoSum
	{
		public static int[] Calculate(int[] nums, int target)
		{
			var indices = new Dictionary<int, int>();
			for (int i = 0; i < nums.Length; ++i)
			{
				int candidate = nums[i];
				if (indices.TryGetValue(candidate, out int index))
				{
					return [index, i];
				}
				indices.TryAdd(target - candidate, i);
			}
			return [];
		}
	}
}
