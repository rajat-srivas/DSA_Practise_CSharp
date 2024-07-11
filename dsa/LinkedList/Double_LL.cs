using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.LinkedList
{
	internal class Double_LL
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

		public void GetDouble()
		{
			CustomLinkedList cll = new CustomLinkedList();
			cll.BuildLinkedList();
			
			var head = cll.headNode;

			var list = head;

			var rhead = recur(list);

			Console.WriteLine("Recurrsive");

			PrintLL(rhead);

			list = rhead;
			int carry = 0;
			while(list != null)
			{
				int dob = list.Data * 2 + carry;
				
					carry = dob / 10;
					dob = dob % 10;

				list.Data = dob;
				list = list.Next;
				
			}

			if(carry > 0)
			{
				var current = rhead;
				while(current.Next != null)
				{
					current = current.Next;
					}
				current.Next = new LLNode(carry);
			}

			Console.WriteLine("doubled");
			rhead = recur(rhead);
			PrintLL(rhead);
			
		}

		private LLNode recur(LLNode node)
		{
			if(node.Next == null) {
				return node;
			
			}

			var newNode = recur(node.Next);
			node.Next.Next = node;
			node.Next = null;

			return newNode;
		}
	}
}
