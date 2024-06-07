using AddTwoNumbers;

namespace AlgorithmsTests
{
	public class AddTwoNumbersTests
	{
		[Fact]
		public void TwoZeros_ReturnZero()
		{
			ListNode l1 = new();
			ListNode l2 = new();
			ListNode result = Calculation.AddTwoNumbers(l1, l2);
			Assert.Equal(0, result.val);
		}

		[Fact]
		public void EqualLength_NoOverflow_ReturnSum()
		{
			ListNode l13 = new(7);
			ListNode l12 = new(0, l13);
			ListNode l11 = new(1, l12);
			ListNode l23 = new(2);
			ListNode l22 = new(9, l23);
			ListNode l21 = new(6, l22);
			ListNode result = Calculation.AddTwoNumbers(l11, l21);
			Assert.Equal(7, result.val);
			Assert.Equal(9, result.next.val);
			Assert.Equal(9, result.next.next.val);
		}

		[Fact]
		public void EqualLength_Overflow_ReturnSum()
		{
			ListNode l13 = new(7);
			ListNode l12 = new(6, l13);
			ListNode l11 = new(6, l12);
			ListNode l23 = new(5);
			ListNode l22 = new(2, l23);
			ListNode l21 = new(6, l22);
			ListNode result = Calculation.AddTwoNumbers(l11, l21);
			Assert.Equal(2, result.val);
			Assert.Equal(9, result.next.val);
			Assert.Equal(2, result.next.next.val);
			Assert.Equal(1, result.next.next.next.val);
		}

		[Fact]
		public void Length1MoreThanLength2_ReturnSum()
		{
			ListNode l13 = new(5);
			ListNode l12 = new(8, l13);
			ListNode l11 = new(4, l12);
			ListNode l22 = new(5);
			ListNode l21 = new(6, l22);
			ListNode result = Calculation.AddTwoNumbers(l11, l21);
			Assert.Equal(0, result.val);
			Assert.Equal(4, result.next.val);
			Assert.Equal(6, result.next.next.val);
		}

		[Fact]
		public void Length2MoreThanLength1_ReturnSum()
		{
			ListNode l12 = new(5);
			ListNode l11 = new(5, l12);
			ListNode l24 = new(4);
			ListNode l23 = new(3, l24);
			ListNode l22 = new(7, l23);
			ListNode l21 = new(6, l22);
			ListNode result = Calculation.AddTwoNumbers(l11, l21);
			Assert.Equal(1, result.val);
			Assert.Equal(3, result.next.val);
			Assert.Equal(4, result.next.next.val);
			Assert.Equal(4, result.next.next.next.val);
		}
	}
}
