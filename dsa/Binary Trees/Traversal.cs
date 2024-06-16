using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Trees
{
	public class Traversal
	{
		public void PreOrderTraversal(Node tree)
		{
			if (tree == null)
				return;

			Console.Write(tree.data + " ");
			PreOrderTraversal(tree.Left);
			PreOrderTraversal(tree.Right);
		}

		public void InOrderTraversal(Node tree)
		{
			if(tree == null) return;
			InOrderTraversal(tree.Left);
			Console.Write(tree.data + " ");
			InOrderTraversal(tree.Right);
		}

		public void PostOrderTraversal(Node tree)
		{
			if (tree == null) return;
			PostOrderTraversal(tree.Left);
			PostOrderTraversal(tree.Right);
			Console.Write(tree.data + " ");
		}

		public void LevelOrderTraversal(Node tree)
		{
			if (tree == null) return;
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(tree);
			queue.Enqueue(null);

			while(queue.Count > 0)
			{
				Node currentNode = queue.Dequeue();
				if(currentNode == null)
				{
					Console.WriteLine();
					if (queue.Count == 0)
						break; //in case it was last null
					else
						queue.Enqueue(null);
				}
				else
				{
					Console.Write(currentNode.data + " ");
					if(currentNode.Left != null)
						queue.Enqueue(currentNode.Left);
					if( currentNode.Right != null)
						queue.Enqueue(currentNode.Right);
				}
			}
		}
	}
}
