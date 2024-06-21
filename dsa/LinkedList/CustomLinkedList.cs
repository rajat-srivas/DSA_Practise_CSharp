using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.LinkedList
{
	public class CustomLinkedList
	{
		public CustomLinkedList() 
		{
		}

		public LLNode headNode = null; 

		public void BuildLinkedList()
		{
			AddFirst("One");
			AddFirst("Two");
			AddFirst("Three");
			AddFirst("I am Head Now");
			AddLast("I will be added to the end");
			AddLast("I am the last node finally");


			PrintLL();

			DeleteFirst();
			DeleteLast();

			PrintLL();
		}

		public void PrintLL()
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
		public void AddFirst(string data)
		{
			var newNode = new LLNode(data);
			if(headNode == null)
			{
				headNode = newNode;
				return;
			}

			newNode.Next = headNode;
			headNode = newNode;
		}
		public void AddLast(string data)
		{
			var lastNode = new LLNode(data);

			var currentNode = headNode;
			while(currentNode.Next != null)
			{
				currentNode = currentNode.Next;
			}

			currentNode.Next = lastNode;


		}

		public void DeleteFirst()
		{
			if (headNode == null)
				return;
			
			headNode = headNode.Next;
			return;
		}

		public void DeleteLast()
		{
			//set next of second last to null
			if (headNode == null)
				return;

			if(headNode.Next == null)
			{
				headNode = null;
				return;
			}
			LLNode secondLast = headNode;
			LLNode lastNode = headNode.Next;

			while(lastNode.Next != null)
			{
				lastNode = lastNode.Next;
				secondLast = secondLast.Next;
			}

			secondLast.Next = null;
		}



	}

	public class LLNode
	{
		public string Data { get; set; }

		public LLNode Next { get; set; }

		public LLNode(string d)
		{
			Data = d;
			Next = null;
		}
	}
}
