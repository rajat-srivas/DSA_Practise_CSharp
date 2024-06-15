using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Trees
{
	internal class BuildTree
	{
		public static int index = -1;
		public Node treeRoot;
		public BuildTree()
		{ 
			
		}

		public Node TreeBuilder()
		{
			int[] nodes = { 1, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };
			treeRoot = Build(nodes);
			return treeRoot;
		}

		public void TraverseTree(Node tree)
		{
			Traversal traverse = new Traversal();

			Console.WriteLine("Pre Order Traversal");
			traverse.PreOrderTraversal(tree);
			Console.WriteLine(Environment.NewLine);

			Console.WriteLine("In Order Traversal");
			traverse.InOrderTraversal(tree);
			Console.WriteLine(Environment.NewLine);

			Console.WriteLine("Post Order Traversal");
			traverse.PostOrderTraversal(tree);
			Console.WriteLine(Environment.NewLine);

			Console.WriteLine("Level Order Traversal");
			traverse.LevelOrderTraversal(tree);
			Console.WriteLine(Environment.NewLine);

			
		}

		public static Node Build(int[] nodeValue)
		{
			index++;
			if (nodeValue[index] == -1)
				return null;

			Node newNode = new Node(nodeValue[index]);
			newNode.Left = Build(nodeValue);
			newNode.Right = Build(nodeValue);

			return newNode;
		}


	}
}
