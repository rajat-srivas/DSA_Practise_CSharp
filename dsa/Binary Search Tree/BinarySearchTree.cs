using dsa.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Binary_Search_Tree
{
	public class BinarySearchTree
	{
		public static int index = -1;
		public static Node rootNode = null;
		public Node BSTBuilder()
		{
			int[] nodes = { 8, 5, 3, 1, 4, 6, 10, 11, 14, 7, 2, 16 };
			for (int i = 0; i < nodes.Length; i++)
			{
				rootNode = Build(nodes[i], rootNode);
			}

			//to check tree was build correctly, do inorder and it should sort

			
			return rootNode;
		}

		public void InOrderTraversal(Node node)
		{
			Traversal traverse = new Traversal();
			Console.WriteLine("In Order Traversal");
			traverse.InOrderTraversal(node);
			Console.WriteLine(Environment.NewLine);
		}

		public  Node Build(int nodeValue, Node? rootNode)
		{
			if(rootNode == null) {
				rootNode = new Node(nodeValue);
				return rootNode;
			}

			if(rootNode.data > nodeValue)
			{
				rootNode.Left = Build(nodeValue, rootNode.Left);
			}
			else
			{
				rootNode.Right = Build(nodeValue, rootNode.Right);
			}

			return rootNode;
		}

		public  void TraverseTree(Node tree)
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

		public static bool SearchBST(Node rootNode,int key)
		{
			if(rootNode == null) return false;

			if(rootNode.data == key)
			{
				return true;
			}

			else
			{
				if(rootNode.data > key)
				{
					return SearchBST(rootNode.Left, key);
				}
				else 
				{
					return SearchBST(rootNode.Right, key);
				}
			}

		}

		public  Node DeleteNode(Node bstNode, int val)
		{
			if (bstNode.data > val)
			{
				bstNode.Left = DeleteNode(bstNode.Left, val);
			}
			else if (bstNode.data < val) 
			{
				bstNode.Right = DeleteNode(bstNode.Right, val);
			}
			else
			{
				//case 1: Node to delete is leaf bstNode
				if(bstNode.Left == null && bstNode.Right == null)
				{
					//replace root will null in the tree
					return null;
				}

				//case 2: only one child, so replace with the child
				if(bstNode.Left == null)
				{
					return bstNode.Right;
				}
				else if(bstNode.Right == null)
				{
					return bstNode.Left;
				}

				// case 3: two child
				//find inorder successor i.e. left most bstNode in right subtree i.e least bstNode greater than it
				//replace bstNode to delete with inorder successor
				//call delete on the inorder successor => this will fall in either case 1 or case 2

				Node inOrder = InOrderSuccessor(bstNode.Right);
				bstNode.data = inOrder.data;
				bstNode.Right = DeleteNode(bstNode.Right, inOrder.data); //find and delete the inorder successor in the right subtree

			}

			return bstNode;
		}

		public static Node InOrderSuccessor(Node node)
		{
			//keep travelling in the left of the current bstNode until the leaf bstNode is found. return that leaf bstNode
			while(node.Left != null)
			{
				node = node.Left;
			}
			return node;

		}

		public void PrintInRage(int start, int end, Node nodeToPrint)
		{
			if (nodeToPrint == null) return;

			// case 1: start <= root < end i.e both side needs to be traversed
			if (nodeToPrint.data >= start && nodeToPrint.data < end)
			{
				PrintInRage(start, end, nodeToPrint.Left);
				Console.Write(nodeToPrint.data + " ");
				PrintInRage(start, end, nodeToPrint.Right);
			}
			else if (nodeToPrint.data > end)
			{
				PrintInRage(start, end, nodeToPrint.Left);
			}
			else
			{
				PrintInRage(start, end, nodeToPrint.Right);
			}

		}

		public void RootToLeafPath(Node nodeToCheck, List<int> paths)
		{
			if (nodeToCheck == null) return;
			paths.Add(nodeToCheck.data);

			if (nodeToCheck.Left == null && nodeToCheck.Right == null)
			{
				ConsolePrint(paths);
			}
			else
			{
				RootToLeafPath(nodeToCheck.Left, paths);
				RootToLeafPath(nodeToCheck.Right, paths);
			}

		
			//delete the last node entered to backtrack
			paths.RemoveAt(paths.Count - 1);			

		}

		private static void ConsolePrint(List<int> paths)
		{
			paths.ForEach(x =>
			{
				Console.Write(x + "->");
			});

			Console.WriteLine();
		}
	}
}
