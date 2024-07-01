
namespace Algorithms
{
	public class MaximumXor
	{
		public static int Calculate(int[] nums)
		{
			if (nums == null || nums.Length == 0)
			{
				return 0;
			}
			if (nums.Length == 1)
			{
				return 0;
			}
			int maxLength = 0;
			for (int i = 0; i < nums.Length; ++i)
			{
				int length = GetBitLength(nums[i]);
				if (length > maxLength)
				{
					maxLength = length;
				}
			}
			TreeNode root = new TreeNode(false);
			for (int i = 0; i < nums.Length; ++i)
			{
				TreeNode curNode = root;
				for (int j = maxLength - 1; j >= 0; --j)
				{
					int mask = 1 << j;
					bool isOne = (nums[i] & mask) != 0;
					if (isOne)
					{
						if (curNode.One == null)
						{
							curNode.One = new TreeNode(true);
						}
						curNode = curNode.One;
					}
					else
					{
						if (curNode.Zero == null)
						{
							curNode.Zero = new TreeNode(false);
						}
						curNode = curNode.Zero;
					}
				}
			}
			TreeNode left = root.One;
			TreeNode right = root.Zero;
			var pairs = new List<Tuple<TreeNode, TreeNode>>
			{
				new(left, right)
			};
			bool[] maxSumArray = new bool[maxLength];
			int curLevel = maxLength -1;
			bool hasBit = false;
			while (curLevel >= 0)
			{
				bool maxBit = false;
				var newPairs = new List<Tuple<TreeNode, TreeNode>>();
				var falsePairs = new List<Tuple<TreeNode, TreeNode>>();
				var altPairs = new List<Tuple<TreeNode, TreeNode>>();
				var falseAltPairs = new List<Tuple<TreeNode, TreeNode>>();
				foreach (var pair in pairs)
				{
					if (pair.Item1 != null && pair.Item2 != null)
					{
						if (pair.Item1.IsOne ^ pair.Item2.IsOne)
						{
							maxBit = true;
							hasBit = true;
							if (pair.Item1.One != null && pair.Item2.Zero != null)
							{
								newPairs.Add(new(pair.Item1.One, pair.Item2.Zero));
							}
							if (pair.Item2.One != null && pair.Item1.Zero != null)
							{
								newPairs.Add(new(pair.Item2.One, pair.Item1.Zero));
							}
							if (newPairs.Count == 0)
							{
								if (pair.Item1.One != null && pair.Item2.One != null)
								{
									altPairs.Add(new(pair.Item1.One, pair.Item2.One));
								}
								if (pair.Item1.Zero != null && pair.Item2.Zero != null)
								{
									altPairs.Add(new(pair.Item1.Zero, pair.Item2.Zero));
								}
							}
						}
						else if (hasBit)
						{
							if (pair.Item1.One != null && pair.Item2.Zero != null)
							{
								falsePairs.Add(new(pair.Item1.One, pair.Item2.Zero));
							}
							if (pair.Item2.One != null && pair.Item1.Zero != null)
							{
								falsePairs.Add(new(pair.Item2.One, pair.Item1.Zero));
							}
							if (newPairs.Count == 0)
							{
								if (pair.Item1.One != null && pair.Item2.One != null)
								{
									falseAltPairs.Add(new(pair.Item1.One, pair.Item2.One));
								}
								if (pair.Item1.Zero != null && pair.Item2.Zero != null)
								{
									falseAltPairs.Add(new(pair.Item1.Zero, pair.Item2.Zero));
								}
							}
						}
					}
					else if (!hasBit && pair.Item1 != null)
					{
						falsePairs.Add(new(pair.Item1.One, pair.Item1.Zero));
					}
					else if (!hasBit && pair.Item2 != null)
					{
						falsePairs.Add(new(pair.Item2.One, pair.Item2.Zero));
					}
				}
				maxSumArray[maxLength - curLevel - 1] = maxBit;
				if (maxBit)
				{
					if (newPairs.Count > 0)
					{
						pairs = newPairs;
					}
					else
					{
						pairs = altPairs;
					}
				}
				else
				{
					if (falsePairs.Count > 0)
					{
						pairs = falsePairs;
					}
					else
					{
						pairs = falseAltPairs;
					}
				}
				curLevel--;
			}
			int result = 0;
			for (int i = 0; i < maxSumArray.Length - 1; i++)
			{
				result += maxSumArray[i] ? 1 : 0;
				result <<= 1;
			}
			result += maxSumArray[maxSumArray.Length - 1] ? 1 : 0;
			return result;
		}

		private static int GetBitLength(int num)
		{
			int length = 0;
			while (num > 0)
			{
				num >>= 1;
				length++;
			}
			return length;
		}

		public class TreeNode
		{
			public bool IsOne = false;
			public TreeNode Zero { get;set; }
			public TreeNode One { get; set; }
			public TreeNode(bool isOne)
			{
				IsOne = isOne;
			}
		}
	}
}
