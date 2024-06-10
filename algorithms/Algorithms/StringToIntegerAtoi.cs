
namespace Algorithms
{
	public class StringToIntegerAtoi
	{
		public static int Calculate(string s)
		{
			if (s == null)
			{
				return 0;
			}
			int i = 0;
			while (i < s.Length)
			{
				if (s[i] == ' ')
				{
					i++;
				}
				else break;
			}
			if (i == s.Length)
			{
				return 0;
			}
			bool isNegative = false;
			if (s[i] == '-' || s[i] == '+')
			{
				isNegative = s[i] == '-';
				i++;
			}
			if (i == s.Length)
			{
				return 0;
			}
			while (i < s.Length && s[i] == '0')
			{
				i++;
			}
			if (i == s.Length || s[i] < '0' || s[i] > '9')
			{
				return 0;
			}
			int startIndex = i;
			while (i < s.Length && s[i] >= '0' && s[i] <= '9')
			{
				i++;
			}
			int length = i - startIndex;
			string numberAsText = (isNegative ? "-" : "") + s.Substring(startIndex, length);
			if (Int32.TryParse(numberAsText, out int number))
			{
				return number;
			}
			else if (isNegative)
			{
				return Int32.MinValue;
			}
			else
			{
				return Int32.MaxValue;
			}
		}
	}
}
