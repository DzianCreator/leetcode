using System.Text;

namespace Algorithms
{
	public class GenerateParenthesis
	{
		public static IList<string> Generate(int n)
		{
			List<string> result = new List<string>();
			if (n < 1)
			{
				return result;
			}
			Partial(result, new StringBuilder(), 0, 0, n);
			return result;
		}

		public static void Partial(IList<string> list, StringBuilder stringBuilder, int open, int close, int max)
		{
			if (stringBuilder.Length == max + max)
			{
				list.Add(stringBuilder.ToString());
			}
			else
			{
				if (open < max)
				{
					stringBuilder.Append("(");
					Partial(list, stringBuilder, open + 1, close, max);
					stringBuilder.Length--;
				}
				if (close < max && close < open)
				{
					stringBuilder.Append(")");
					Partial(list, stringBuilder, open, close + 1, max);
					stringBuilder.Length--;
				}
			}
		}
	}
}
