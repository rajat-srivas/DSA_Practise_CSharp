using dsa.Trees;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Binary_Trees
{
	public class LeftRightViewTree
	{

		//Left view means printing the first node of each level
		//right view means last node of each level
		public void ViewGenerator()
		{
			var treeToView = GetTree();

			List<int> leftNodes = new List<int>();
			List<int> rightNodes = new List<int>();

			int level = 0;

			GenerateLeftView(treeToView, level, leftNodes);
			Print(leftNodes, "Left View using Recurssion");

			Console.WriteLine("Left View using Queue");
			ViewUsingQueue(treeToView, "LEFT");
			Console.WriteLine();

			GenerateRightView(treeToView, level, rightNodes);
			Print(rightNodes, "Right View Using Recurssion ");

			Console.WriteLine("Right View using Queue");
			ViewUsingQueue(treeToView, "RIGHT");


		}

		private void ViewUsingQueue(Node treeToView, string view)
		{
			if (treeToView == null)
				return ;

			Queue<Node> q = new Queue<Node>();
			q.Enqueue(treeToView);

			while(q.Count > 0) 
			{
				int count = q.Count;

				for (int i = 0; i <count; i++)
				{
					var node = q.Peek();
					q.Dequeue();

					//if left view, print the first item of that level
					if(view == "LEFT" & i == 0)
						Console.Write(node.data + " ");
					
					// if last view print the last item of that level
					if(view == "RIGHT" & i == count - 1)
						Console.Write(node.data + " ");

					if (node.Left !=  null)
					{
						q.Enqueue(node.Left);
					}
					if (node.Right != null)
					{
						q.Enqueue(node.Right);
					}

				}
			}

		}

		private void Print(List<int> view, string msg)
		{
			Console.WriteLine(msg);
            foreach (var item in view)
            {
				Console.Write(item + " ");
            }
			Console.WriteLine();
        }

		private void GenerateLeftView(Node treeToView, int level, List<int> leftNodes)
		{
			if(treeToView == null) return;

			if(level == leftNodes.Count)
			{
				leftNodes.Add(treeToView.data);
			}

			GenerateLeftView(treeToView.Left, level + 1, leftNodes);
			GenerateLeftView(treeToView.Right, level + 1, leftNodes);
		}

		private void GenerateRightView(Node treeToView, int level, List<int> rightNodes)
		{
			if (treeToView == null) return;

			if (level == rightNodes.Count)
			{
				rightNodes.Add(treeToView.data);
			}

			GenerateRightView(treeToView.Right, level + 1, rightNodes);
			GenerateRightView(treeToView.Left, level + 1, rightNodes);
		}

		private Node GetTree()
		{
			BuildTree btree = new BuildTree();
			Node tree = btree.TreeBuilder();
			//btree.TraverseTree(tree);
			return tree;
		}
	}
}
