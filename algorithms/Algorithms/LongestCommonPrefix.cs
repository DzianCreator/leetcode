
namespace Algorithms
{
	public class LongestCommonPrefix
	{
		public static string Calculate(string[] strs)
		{
			if (strs == null || strs.Length == 0)
			{
				return "";
			}
			int prefixLength = strs[0].Length;
			for (int i = 1; i < strs.Length; ++i)
			{
				int k = 0;
				while (k < prefixLength && k < strs[0].Length && k < strs[i].Length && strs[0][k] == strs[i][k])
				{
					k++;
				}
				if (k < prefixLength)
				{
					prefixLength = k;
				}
			}
			return strs[0].Substring(0, prefixLength);
		}
	}
}
