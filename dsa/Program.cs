using System.IO.Compression;
using System.Text;
using System.Text.RegularExpressions;
using dsa.Binary_Search_Tree;
using dsa.Graphs;
using dsa.Trees;

namespace dsa
{
    internal class Program
	{

		static void Main(string[] args)
		{
			Longest_Palindrome_Substring longest = new Longest_Palindrome_Substring();
			string input ="forgeeksskeegfor";
			int length = longest.LongestPalindrome(input);

			Console.WriteLine("Longest Plaindrome in " + input + " : " + length );

			//Kadane_MaxSumInSubArray kadane = new Kadane_MaxSumInSubArray();
			//kadane.CalculateMaxSumInSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

			//Graph();
			//BinaryTree();
			//CalculateYearPercentage();
			//MultipleProblems();


			//BST();

			Console.ReadLine();

		}

		public static void BST()
		{
			BinarySearchTree bst = new BinarySearchTree();
			
			Node bstNode = bst.BSTBuilder();
			bst.InOrderTraversal(bstNode);

			//bool result = BinarySearchTree.SearchBST(bstNode, 19);
			//Console.WriteLine(result);

			//Console.WriteLine("Deleting Node");
			//bst.DeleteNode(bstNode, 5);
			//bst.InOrderTraversal(bstNode);

			//bst.PrintInRage(5, 15, bstNode);

			bst.RootToLeafPath(bstNode, new List<int>());

		}

		private static void BinaryTree()
		{
			BuildTree treeBuilder = new BuildTree();
			Node tree = treeBuilder.TreeBuilder();

			treeBuilder.TraverseTree(tree);

			TreeProblems prob = new TreeProblems();

			Console.WriteLine("Count of Nodes in tree");
			int count = prob.CountOfNodes(tree);
			Console.WriteLine(count + Environment.NewLine);

			Console.WriteLine("Sum of Nodes in tree");
			int sum = prob.SumOfNodes(tree);
			Console.WriteLine(sum + Environment.NewLine);

			Console.WriteLine("Height of Nodes in tree");
			int height = prob.HeightOfTree(tree);
			Console.WriteLine(height + Environment.NewLine);

			Console.WriteLine("Sum of nodes at Kth Level");
			int sumLevel = prob.SumOfNodesAtKthLevel(tree, 2);
			Console.WriteLine(sumLevel + Environment.NewLine);

		}
		public static void Graph()
		{
			Graph graph = new Graph(7);
			graph.CreateGraph();
			var list = graph.GetNeighbours(2);

			Console.WriteLine("Breadth First Traversal");
			graph.BFS(0);

			Console.WriteLine(Environment.NewLine);

			bool[] visited = new bool[7];
			Console.WriteLine("Depth First Traversal - Recurssive");
			graph.DFS_Recurssive(0, visited);

			Console.WriteLine(Environment.NewLine);

			Console.WriteLine("Depth First Traversal - Stack");
			graph.DFS_Stack(0);

			Console.WriteLine(Environment.NewLine);

			Console.WriteLine("Path from 0 => 5" + Environment.NewLine);
			visited = new bool[7];
			string path = "0";
			graph.PathToTarget(visited, 0, path, 5);

			TopologicalSorting sorting = new TopologicalSorting();
			sorting.TopologicalSortOrder(6);

			ShortestPath shortestPath = new ShortestPath();
			shortestPath.Dijkstra(0, 6);


		}

		public static void CalculateYearPercentage()
		{
			var date = new DateTime(2020, 07, 02, 0, 0, 0);
			Console.WriteLine(date);

			bool leapYear = date.Year % 4 == 0;
			int totalSeconds = leapYear ? 366 * 24 * 60 * 60 : 355 * 24 * 60 * 60;

			var minutesGoneTillYesterday = date - new DateTime(date.Year, 1, 1, 0, 0, 0);
			var todaySeconds = (date.Hour * 60 * 60) + (date.Minute * 60) + date.Second;

			var totalSecondsGone = (minutesGoneTillYesterday.TotalSeconds) + todaySeconds;

			double percent = (totalSecondsGone / totalSeconds) * 100;
			Console.WriteLine("Percentage of year completed " + percent.ToString("0.000"));
		}
		public static void MultipleProblems()
		{

			Console.WriteLine("Choose the problem to execute");
			Console.WriteLine("Select 1 for Three Sum");
			Console.WriteLine("Select 2 for Move Zero's to End");
			Console.WriteLine("Select 3 for Mountain Array");

			string choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					Three_Sum_Problem three = new Three_Sum_Problem();
					var result = three.ThreeSumProblem(new List<int>() { -1, 9, 2, 3, 6, 4 }, 10);
					Console.WriteLine(result);
					break;
				case "2":
					Move_Zeros_To_End move = new Move_Zeros_To_End();
					var zeros = move.MoveZeroToEnd(new int[] { 0, 1, 0, 3, 12 });
					foreach (var item in zeros)
					{
						Console.Write(item + " ,");
					}
					break;
				case "3":
					Mountain_Array mountain = new Mountain_Array();
					var isMountain = mountain.ValidMountainArray();
					Console.WriteLine(isMountain);
					break;
				default:
					Console.WriteLine("Choose current option to continue");
					break;
			}
		}


	}
}

#region



#endregion