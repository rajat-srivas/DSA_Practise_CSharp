using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Trees
{
	public  class TreeProblems
	{
		public int CountOfNodes(Node root)
		{
			if (root == null)
				return 0;

			int countOfLeft = CountOfNodes(root.Left);
			int countOfRight = CountOfNodes(root.Right);

			return countOfLeft + countOfRight + 1;
		}

		public int SumOfNodes(Node tree)
		{
			if(tree == null)
				return 0;

			int sumOfLeft = SumOfNodes(tree.Left);
			int sumOfRight = SumOfNodes(tree.Right);

			return sumOfLeft + sumOfRight + tree.data;

		}

		public int HeightOfTree(Node root)
		{
			if(root == null)return 0;

			int leftHeight = HeightOfTree(root.Left);
			int rightHeight = HeightOfTree(root.Right);

			int height = Math.Max(leftHeight, rightHeight) + 1;

			return height;
		}

		public int SumOfNodesAtKthLevel(Node tree, int KthLevel)
		{
			if (tree == null) return 0;
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(tree);
			queue.Enqueue(null);
			int sum = 0;

			int level = 1;

			while (queue.Count > 0)
			{
				Node currentNode = queue.Dequeue();
				if (currentNode == null)
				{
					level++;
					if (queue.Count == 0)
						break; //in case it was last null
					else
						queue.Enqueue(null);
				}
				else
				{
					if(level == KthLevel)
					{
						sum+= currentNode.data;
					}
					if (currentNode.Left != null)
						queue.Enqueue(currentNode.Left);
					if (currentNode.Right != null)
						queue.Enqueue(currentNode.Right);
				}
			}

			return sum;
		}
	}
}
