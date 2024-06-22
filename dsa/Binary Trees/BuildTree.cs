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
			int[] nodes = { 1, 2 ,-1, 4, -1, -1, 5,  3, -1,-1,  6, -1, 7, -1, 8, 9, -1, 10 };
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

			// Check if index is within the bounds of the array
			if (index >= nodeValue.Length)
				return null;


			if (nodeValue[index] == -1)
				return null;

			
			Node newNode = new Node(nodeValue[index]);
			newNode.Left = Build(nodeValue);
			newNode.Right = Build(nodeValue);

			return newNode;
		}


	}
}
