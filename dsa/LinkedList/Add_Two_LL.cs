using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.LinkedList
{
	internal class Add_Two_LL
	{
		public void SumLinkedList()
		{
			var one = new CustomLinkedList();
			one.AddFirst(2);
			one.AddLast(4);
			one.AddLast(9);

			var two = new CustomLinkedList();
			two.AddFirst(5);
			two.AddLast(6);
			two.AddLast(4);
			two.AddLast(9);

			LLNode node = AddTwoNumbers(one.headNode, two.headNode);

			PrintLL(node);
		}

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
		public LLNode AddTwoNumbers(LLNode l1, LLNode l2)
		{
			var one = Rev(l1);
			var two = Rev(l2);

			LLNode node = new LLNode(0);
			var current = node;
			int carry = 0;
			var result = new List<int>();
			while (one != null && two != null)
			{
				var s = one.Data + two.Data + carry;
				carry = s / 10;
				s = s % 10;
				

				result.Add(s);


				if (one.Next == null && two.Next != null)
				{
					one.Next = new LLNode(0);
				}

				else if (two.Next == null && one.Next != null)
				{
					two.Next = new LLNode(0);
				}

				one = one.Next;
				two = two.Next;


			}

			if (carry > 0)
			{
				result.Add(carry);
			}

			for (int i = 0; i < result.Count; i++)
			{
				while (current.Next != null)
				{
					current = current.Next;
				}

				current.Next = new LLNode(result[i]);
			}

			return node.Next;
		}

		public LLNode Rev(LLNode head)
		{
			if (head.Next == null)
				return head;

			var newHead = Rev(head.Next);
			head.Next.Next = head;
			head.Next = null;

			return newHead;
		}
	}
}
