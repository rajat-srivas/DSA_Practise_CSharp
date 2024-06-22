using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace dsa.LinkedList
{
	public class CyclicLinkedList
	{
		//Floyd Algorithm or the Tortoise and Hare Algorithm (used in reverse as slow & fast)
		//If the fast pointer meets the slow pointer, a cycle is detected.
		//If the fast pointer reaches the end(null), there is no cycle.
		public void HasCycle()
		{
			var cyclicHead = CreateLinkedListWithCycle();

			var fast = cyclicHead;
			var slow = cyclicHead;

			while (fast != null && fast.Next != null)
			{
				fast = fast.Next.Next;
				slow = slow.Next;

				if(fast == slow)
				{
					Console.WriteLine("Cycle Detected");
					RemoveCycle(cyclicHead, fast);
					return;
				}
			}

			Console.WriteLine("No Cycle Found");
			return;
		}

		public void RemoveCycle(LLNode head, LLNode fast)
		{
			//After detecting the cycle, reset one pointer(slow) to the head of the list while keeping the other pointer(fast) at the meeting point.
			//Move both pointers one step at a time until they meet again. The meeting point will be the start of the cycle.
			//To remove the cycle, traverse the cycle to find the node just before the start of the cycle(the node whose next pointer points to the start of the cycle).
			//Set this node's next pointer to null, breaking the cycle.

			// Find the start of the cycle
			LLNode slow = head;
			while (slow != fast)
			{
				slow = slow.Next;
				fast = fast.Next;
			}

			// Find the node just before the start of the cycle
			LLNode cycleStart = slow;
			LLNode prev = null;
			while (fast.Next != cycleStart)
			{
				prev = fast;
				fast = fast.Next;
			}

			// Remove the cycle
			if (prev != null)
			{
				fast.Next = null;
			}
		}
	

		public LLNode CreateLinkedListWithCycle()
		{
			int[] values = { 1, 2, 3, 4, 5 , 6,7,8 };
			int pos = 4; // The position where the cycle starts (0-based index)

			if (values.Length == 0)
			{
				return null;
			}

			LLNode head = new LLNode(values[0].ToString());
			var current = head;
			LLNode cycleNode = null;

			for (int i = 1; i < values.Length; i++)
			{
				current.Next = new LLNode(values[i].ToString());
				current = current.Next;
				if (i == pos)
				{
					cycleNode = current;
				}
			}

			// Creating the cycle
			if (pos >= 0)
			{
				current.Next = cycleNode;
			}

			return head;
		}
	}
}

