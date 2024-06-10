
namespace Algorithms
{
	public class LongestPalindromicString
	{
		public static string Calculate(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return string.Empty;
			}
			int i = 0;
			int iStart = 0;
			int pLength = 0;
			while (i < s.Length)
			{
				int lower = i - 1;
				int higher = i + 1;
				int curLength = 1;
				//odd
				while (lower > -1 && higher < s.Length)
				{
					if (s[lower] == s[higher])
					{
						lower--;
						higher++;
						curLength += 2;
					}
					else break;
				}
				if (curLength > pLength)
				{
					iStart = lower + 1;
					pLength = curLength;
				}
				//even
				lower = i - 1;
				higher = i;
				curLength = 0;
				while (lower > -1 && higher < s.Length)
				{
					if (s[lower] == s[higher])
					{
						lower--;
						higher++;
						curLength += 2;
					}
					else break;
				}
				if (curLength > pLength)
				{
					iStart = lower + 1;
					pLength = curLength;
				}
				i++;
			}
			return s.Substring(iStart, pLength);
		}
	}
}
