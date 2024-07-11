using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.LinkedList
{
	public class ReverseLinkedList
	{
		public ReverseLinkedList() { }
		public void Reverse()
		{
			//LinkedList<int> list = new LinkedList<int>();
			CustomLinkedList list = new CustomLinkedList();
			//list.AddFirst("1");
			//list.AddLast("2");
			//list.AddLast("3");
			//list.AddLast("4");
			//list.AddLast("5");
			//list.AddLast("6");
			//list.AddLast("7");

			Console.WriteLine("Current List");
			list.PrintLL();

			ReverseIterate(list);
		}
		private void ReverseIterate(CustomLinkedList list)
		{
			//no node or 
			if (list.headNode == null || list.headNode.Next == null)
				return;

			var previous = list.headNode;
			var current = previous.Next;

			while(current != null)
			{
				var next = current.Next;

				//target to previous instead of next to mark it as reverse
				current.Next = previous;

				//shift forward
				previous = current;
				current = next;
			}

			//now mark head to point to next = null
			list.headNode.Next = null;
			list.headNode = previous;

			Console.WriteLine("Reversed LinkedList");
			list.PrintLL();

			//previous is marked as head as the in the end of above while loop current will become null, and previous will be pointing to
			//current i.e. previous will be last node
		}
		public void Print(LinkedList<int> list)
		{
            foreach (var item in list)
            {
				Console.Write(item + " => ");   
            }
        }
	}
}
