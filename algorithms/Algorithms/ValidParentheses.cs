
namespace Algorithms
{
	public class ValidParentheses
	{
		public static bool Calculate(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return false;
			}
			Stack<char> validator = new Stack<char>();
			for (int i = 0; i < s.Length; ++i)
			{
				if (s[i] == '{' || s[i] == '(' || s[i] == '[')
				{
					validator.Push(s[i]);
				}
				else
				{
					if (validator.TryPop(out char last))
					{
						if (s[i] == '}')
						{
							if (last != '{')
							{
								return false;
							}
						}
						else if (s[i] == ']')
						{
							if (last != '[')
							{
								return false;
							}
						}
						else
						{
							if (last != '(')
							{
								return false;
							}
						}
					}
					else
					{
						return false;
					}
				}
			}
			return validator.Count == 0;
		}
	}
}
