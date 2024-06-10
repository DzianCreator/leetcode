
namespace Algorithms
{
	public class ReverseInteger
	{
		public static int Calculate(int x)
		{
			string numberAsText = x.ToString();
			if (x < 0)
			{
				numberAsText = numberAsText.Substring(1);
			}
			string reverseNumberAsText = new string(numberAsText.Reverse().ToArray());
			if (x < 0)
			{
				reverseNumberAsText = "-" + reverseNumberAsText;
			}
			Int32 result;
			if (Int32.TryParse(reverseNumberAsText, out result))
			{
				return result;
			}
			else
			{
				return 0;
			}
		}
	}
}
