using Algorithms;

namespace AlgorithmsTests
{
	public class MergeTwoSortedListsTests
	{
		[Fact]
		public void BothEmpty_ReturnEmpty()
		{
			var result = MergeTwoSortedLists.Calculate(null, null);
			Assert.Null(result);
		}

		[Fact]
		public void FirstEmpty_ReturnSecond()
		{
			var result = MergeTwoSortedLists.Calculate(null, new ListNode(1));
			Assert.Equal(1, result.val);
			Assert.Null(result.next);
		}

		[Fact]
		public void SecondEmpty_ReturnFirst()
		{
			var result = MergeTwoSortedLists.Calculate(new ListNode(2), null);
			Assert.Equal(2, result.val);
			Assert.Null(result.next);
		}

		[Fact]
		public void AllFirstAfterSecond_ReturnSorted()
		{
			var result = MergeTwoSortedLists.Calculate(new ListNode(3, new ListNode(4)), new ListNode(1, new ListNode(2)));
			Assert.Equal(1, result.val);
			Assert.Equal(2, result.next.val);
			Assert.Equal(3, result.next.next.val);
			Assert.Equal(4, result.next.next.next.val);
			Assert.Null(result.next.next.next.next);
		}

		[Fact]
		public void AllSecondAfterFirst_ReturnSorted()
		{
			var result = MergeTwoSortedLists.Calculate(new ListNode(1, new ListNode(2)), new ListNode(3, new ListNode(4)));
			Assert.Equal(1, result.val);
			Assert.Equal(2, result.next.val);
			Assert.Equal(3, result.next.next.val);
			Assert.Equal(4, result.next.next.next.val);
			Assert.Null(result.next.next.next.next);
		}

		[Fact]
		public void DifferentLists_ReturnSorted()
		{
			var result = MergeTwoSortedLists.Calculate(new ListNode(1, new ListNode(3)), new ListNode(2, new ListNode(4)));
			Assert.Equal(1, result.val);
			Assert.Equal(2, result.next.val);
			Assert.Equal(3, result.next.next.val);
			Assert.Equal(4, result.next.next.next.val);
			Assert.Null(result.next.next.next.next);
		}
	}
}
