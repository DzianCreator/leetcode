
namespace Algorithms
{
	public class MergeTwoSortedLists
	{
		public static ListNode Calculate(ListNode list1, ListNode list2)
		{
			if (list1 == null)
			{
				return list2;
			}
			if (list2 == null)
			{
				return list1;
			}
			ListNode result = null;
			ListNode current1 = list1;
			ListNode current2 = list2;
			if (list1.val < list2.val)
			{
				result = new ListNode(list1.val);
				current1 = list1.next;
			}
			else
			{
				result = new ListNode(list2.val);
				current2 = list2.next;
			}
			ListNode resultCurrent = result;
			while (current1 != null || current2 != null)
			{
				if (current1 == null)
				{
					resultCurrent.next = new ListNode(current2.val);
					current2 = current2.next;
					resultCurrent = resultCurrent.next;
				}
				else if (current2 == null)
				{
					resultCurrent.next = new ListNode(current1.val);
					current1 = current1.next;
					resultCurrent = resultCurrent.next;
				}
				else
				{
					if (current1.val < current2.val)
					{
						resultCurrent.next = new ListNode(current1.val);
						current1 = current1.next;
						resultCurrent = resultCurrent.next;
					}
					else
					{
						resultCurrent.next = new ListNode(current2.val);
						current2 = current2.next;
						resultCurrent = resultCurrent.next;
					}
				}
			}
			return result;
		}
	}
}
