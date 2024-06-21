using dsa.Trees;
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
			this.Size = 0;
		}

		public LLNode headNode = null;
		private int Size;

		public void BuildLinkedList()
		{
			AddFirst("1");
			AddLast("2");
			AddLast("3");
			AddLast("4");
			AddLast("5");
			AddLast("6");
			AddLast("7");
			AddLast("8");
			AddLast("9");

			GetSize();

			PrintLL();

			//DeleteFirst();
			//DeleteLast();

			//GetSize();

			//PrintLL();

			//BuiltInLL ll = new BuiltInLL();
			//ll.Build();



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
			Size++;
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
			Size++;
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

			Size--;
			
			headNode = headNode.Next;
			return;
		}

		public void GetSize()
		{
			Console.WriteLine("Size of Linked List = " + Size);
		}

		public void DeleteLast()
		{
			//set next of second last to null
			if (headNode == null)
				return;

			Size--;

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

		public void DeleteNthNodeFromEnd(int index)
		{
			Console.WriteLine("Deleting node from end " + index);

			if (headNode == null) return;

			if (headNode.Next == null)
				DeleteFirst();

			if(Size == index)
			{
				//deleting the head
				DeleteFirst();
			}

			int count = 1;

			//Nth from end = will be next of size - n
			//1 2 3 4 5 6 7 8 9 = >
			//n = 3 , 9 -3 = 6, next of 6 is 7 which is 3rd from end

			var previous = headNode;

			while (count < (Size - index))
			{
				previous = previous.Next;
				count++;
			}
			previous.Next = previous.Next.Next;

			PrintLL();

			//Console.WriteLine(previous.Data);
			//Console.WriteLine(current.Data);
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

	public class BuiltInLL()
	{
		public void Build()
		{
			LinkedList<string> list = new LinkedList<string>();
			list.AddFirst("One");
			list.AddFirst("Two");
			list.AddLast("Three");
            foreach (var item in list)
            {
				Console.Write(item + " ");
            }

        }

	}
}
