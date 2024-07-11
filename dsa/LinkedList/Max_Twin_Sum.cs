using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.LinkedList
{
	internal class Max_Twin_Sum
	{
		public void PrintLL(LLNode headNode)
		{
			if (headNode == null)
			{
				Console.WriteLine("List is empty");
			}

			var currentNode = headNode;
			while (currentNode != null)
			{
				Console.Write(currentNode.Data + " => ");
				currentNode = currentNode.Next;
			}

			Console.Write("NULL");
			Console.WriteLine();
		}


		private LLNode Middle(LLNode node)
		{
			LLNode slow = node;
			LLNode fast = node;

			while (fast != null && fast.Next != null)
			{
				slow = slow.Next;
				fast = fast.Next.Next;
			}

			return slow;
		}
		public void GetMaxSum()
		{
			CustomLinkedList cll = new CustomLinkedList();
			cll.BuildLinkedList();
			var head = cll.headNode;
			int max = 0;

			var list = head;
			var middle = Middle(head);

			PrintLL(middle);

			var rhead = rec(middle);

			PrintLL(rhead);

			while (rhead != null)
			{
				int sum = Convert.ToInt32(list.Data) + Convert.ToInt32(rhead.Data);
				if (sum > max)
					max = sum;

				list = list.Next;
				rhead = rhead.Next;
			}

			Console.WriteLine(max);

		}

		private LLNode rec(LLNode start)
		{
			if (start == null || start.Next == null)
				return start;

			var newHead = rec(start.Next);
			start.Next.Next = start;
			start.Next = null;

			return newHead;
		}

	}
}
