
namespace Algorithms
{
	public class IntegerIsPalindrome
	{
		public static bool Calculate(int x)
		{
			if (x < 0)
			{
				return false;
			}
			if (x < 10)
			{
				return true;
			}
			string xText = x.ToString();
			int median = xText.Length / 2;
			int lowerIndex = median - 1;
			int higherIndex = (xText.Length % 2 == 1) ? median + 1 : median;
			while (higherIndex < xText.Length)
			{
				if (xText[lowerIndex] != xText[higherIndex])
				{
					return false;
				}
				higherIndex++;
				lowerIndex--;
			}
			return true;
		}
	}
}
