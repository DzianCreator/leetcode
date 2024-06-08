
namespace Algorithms
{
	public class LongestSubstringWithoutRepeatingCharacters
	{
		public static int Calculate(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return 0;
			}
			int maxSubLength = 0;
			int subFirstIndex = 0;
			Dictionary<char, int> indices = [];
			for (int i = 0; i < s.Length; ++i)
			{
				if (!indices.ContainsKey(s[i]))
				{
					indices.Add(s[i], i);
				}
				else
				{
					int newFirstIndex = indices[s[i]] + 1;
					for (int j = subFirstIndex; j < newFirstIndex; ++j)
					{
						indices.Remove(s[j]);
					}
					indices.Add(s[i], i);
					subFirstIndex = newFirstIndex;
				}
				if (indices.Count > maxSubLength)
				{
					maxSubLength = indices.Count;
				}
			}
			return maxSubLength;
		}
	}
}
