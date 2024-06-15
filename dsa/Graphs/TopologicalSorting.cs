using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Graphs
{
	public class TopologicalSorting
	{
		//Topological sorting can be  done only for Directed acyclic graph
		//used to indicate dependecy in some related operations
		//used DFS

		//we need to make sure all nodes are visited in case there are some disconnected elements
		//so we call main method inside a loop

		public void TopologicalSortOrder(int vertex)
		{
			Graph graph = new Graph(vertex);
			graph.CreateGraphForTopology();

			bool[] visted = new bool[vertex];
			Stack order = new Stack(); 
			for(int i = 0; i < vertex; i++)
			{
				if (!visted[i])
				{
					TopologyDFS(i, visted, order, graph);
				}
			}

			Console.WriteLine("Topological Sort Order: " + Environment.NewLine);

            while(order.Count > 0) 
			{
				Console.WriteLine(order.Pop() + " ");
			}

        }

		public void TopologyDFS(int startPoint, bool[] visited, Stack order, Graph graph)
		{
			visited[startPoint] = true;
			var neighbours = graph.GetNeighbourNodes(startPoint);
			neighbours.ForEach(neighbour =>
			{
				if (!visited[neighbour]) 
				{
					visited[neighbour] = true;
					TopologyDFS(neighbour,visited,order, graph);
				}
			});

			//This is the difference from DFS as we want parent to written before its dependency so we use stack
			order.Push(startPoint);
		}

	}
}
