using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace dsa.LinkedList
{
	public class PalindromeLinkedList
	{
		//1 - 2 - 3- 2 - 1 - null
		public void Palindrome()
		{
			CustomLinkedList list = new CustomLinkedList();
			//list.AddFirst("1");
			//list.AddLast("2");
			//list.AddLast("3");
			//list.AddLast("4");
			//list.AddLast("3");
			//list.AddLast("2");
			//list.AddLast("1");

			Console.WriteLine("Current List");
			list.PrintLL();

			list.headNode = RecurssiveReverse(list.headNode);
			Console.WriteLine("Reverse the linkedlist using Recurrsive method");
			list.PrintLL();

			CheckPalindrome(list);

		}

		private void CheckPalindrome(CustomLinkedList list)
		{
			//step 1
			//Middle using Two-Pointer Technique (Tortoise and Hare Algorithm)

			LLNode middleNode = FindMiddle(list);
			Console.WriteLine(Environment.NewLine + "Middle Node of List: " + middleNode.Data);

			//step 2
			LLNode reversedHead = ReverseFromMiddle(middleNode.Next);
			Console.WriteLine(Environment.NewLine);

			//step 3
			//Compare first and secondHalf
			var startHead = list.headNode;
			while (reversedHead != null)
			{
				if (startHead.Data != reversedHead.Data)
				{
					Console.WriteLine("Not Palindrome");
					return;
				}

				startHead = startHead.Next;
				reversedHead = reversedHead.Next;
			}

			Console.WriteLine("Palindrome");
		}

		//reverse the node from the next node of middle
		private LLNode ReverseFromMiddle(LLNode reverseHead)
		{
			if(reverseHead == null || reverseHead.Next == null)
			{
				return reverseHead;
			}

			LLNode prev = null;
			var current = reverseHead;

			while(current != null)
			{
				var next  = current.Next;

				current.Next = prev;

				prev = current;
				current = next;
			}

			reverseHead.Next = null;
			return prev;
		}


		private LLNode RecurssiveReverse(LLNode headNode)
		{
			// Base case: if headNode is null or only one node, return it
			if (headNode == null || headNode.Next == null)
			{
				return headNode;
			}

			// Recursive case: reverse the rest of the list
			var newHead = RecurssiveReverse(headNode.Next);

			// Set the next node's next pointer to point back to current node
			// i.e the next node should point back to me
			headNode.Next.Next = headNode;

			// Set current node's next pointer to null
			// delete the current mapping from right - left as in above we made left - right
			headNode.Next = null;

			return newHead;

		}

		//Initialize both slow and fast pointers to the head of the linked list.
		//Move the slow pointer one step at a time.
		//Move the fast pointer two steps at a time.
		//When the fast pointer reaches the end of the list, the slow pointer will be at the middle node.

		private LLNode FindMiddle(CustomLinkedList list)
		{
			var slow = list.headNode;
			var fast = list.headNode;

			while(fast.Next != null && fast.Next.Next != null)
			{
				slow = slow.Next;
				fast = fast.Next.Next;
			}

			return slow;
		}
	}
}
