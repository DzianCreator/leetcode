
namespace Algorithms
{
	public class LongestValidParentheses
	{
		public static int Calculate(string s)
		{
			if (s == null)
			{
				return 0;
			}
			bool[] match = new bool[s.Length];
			int sequenceBreakIndex = -1;
			for (int i = 0; i < s.Length; ++i)
			{
				if (s[i] == '(')
				{
					match[i] = false;
				}
				else
				{
					int j = i - 1;
					while (j > sequenceBreakIndex)
					{
						if (!match[j])
						{
							match[i] = true;
							match[j] = true;
							break;
						}
						j--;
					}
					if (j == sequenceBreakIndex)
					{
						sequenceBreakIndex = i;
					}
				}
			}
			int longest = 0;
			int candidate = 0;
			for (int i = 0; i < match.Length; ++i)
			{
				if (match[i])
				{
					candidate++;
				}
				else
				{
					if (longest < candidate)
					{
						longest = candidate;
					}
					candidate = 0;
				}
			}
			if (longest < candidate)
			{
				longest = candidate;
			}
			return longest;
		}
	}
}
