
namespace Algorithms
{
	public class ZigzagStringConversion
	{
		public static string Calculate(string s, int numRows)
		{
			if (s == null)
			{
				return string.Empty;
			}
			if (numRows < 2)
			{
				return s;
			}
			int lastRowIndex = numRows - 1;
			char[] resultArray = new char[s.Length];
			int resultIndex = 0;
			int period = numRows + numRows - 2;
			for (int i = 0; i < s.Length; i += period)
			{
				resultArray[resultIndex] = s[i];
				resultIndex++;
			}
			int decreasingPeriod = period;
			int increasingPeriod = 0;
			int rowIndex = 1;
			while (rowIndex < lastRowIndex)
			{
				decreasingPeriod -= 2;
				increasingPeriod += 2;
				bool isDecreasing = true;
				int j = rowIndex;
				while (j < s.Length)
				{
					resultArray[resultIndex] = s[j];
					resultIndex++;
					if (isDecreasing)
					{
						j += decreasingPeriod;
					}
					else
					{
						j += increasingPeriod;
					}
					isDecreasing = !isDecreasing;
				}
				rowIndex++;
			}
			for (int i = lastRowIndex; i < s.Length; i += period)
			{
				resultArray[resultIndex] = s[i];
				resultIndex++;
			}
			return new string(resultArray);
		}
	}
}
