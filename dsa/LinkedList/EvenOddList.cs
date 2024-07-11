using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.LinkedList
{
	public class EvenOddList
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
		public void OddEvenList()
		{
			CustomLinkedList cll = new CustomLinkedList();
			cll.BuildLinkedList();
			var head = cll.headNode;

			if (head == null || head.Next == null)
			{
				Console.WriteLine(head.Data + Environment.NewLine); return;
			}
			LLNode oddHead = head;
			LLNode evenHead = head.Next;
			var temp = evenHead;

			while (evenHead != null && evenHead.Next != null && evenHead.Next != null)
			{
				oddHead.Next = oddHead.Next.Next;
				evenHead.Next = evenHead.Next.Next;
				evenHead = evenHead.Next;
				oddHead = oddHead.Next;
			}

			oddHead.Next = temp;

			Console.WriteLine("Even Odd Seperated");
			PrintLL(head);
		}
	}
}
