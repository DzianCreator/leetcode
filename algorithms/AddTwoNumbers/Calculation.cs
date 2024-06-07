namespace AddTwoNumbers
{
	public class Calculation
	{
		public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			ListNode value1 = l1;
			ListNode value2 = l2;
			ListNode resultPrevNode = null;
			ListNode resultFirstNode = null;
			int overflow = 0;
			do
			{
				int resultVal = (value1?.val ?? 0) + (value2?.val ?? 0) + overflow;
				if (resultVal > 9)
				{
					resultVal -= 10;
					overflow = 1;
				}
				else
				{
					overflow = 0;
				};
				ListNode valNode = new(resultVal);
				if (resultPrevNode == null)
				{
					resultFirstNode = valNode;
					resultPrevNode = valNode;
				}
				else
				{
					resultPrevNode.next = valNode;
					resultPrevNode = valNode;
				}
				if (value1 != null)
				{
					value1 = value1.next;
				}
				if (value2 != null)
				{
					value2 = value2.next;
				}
			}
			while (value1 != null || value2 != null);
			if (overflow != 0)
			{
				ListNode valNode = new(overflow);
				resultPrevNode.next = valNode;
			}
			return resultFirstNode;
		}
	}
}
