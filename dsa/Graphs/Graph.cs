using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Graphs
{
    public class Graph
    {
        private static int vertex;
        List<Edge>[] graph;

        public Graph(int v)
        {
            vertex = v;
        }

        public void CreateGraph()
        {
            graph = new List<Edge>[vertex];

            for (int i = 0; i < graph.Length; i++)
            {
                graph[i] = new List<Edge>();
            }

            graph[0].Add(new Edge(0, 1));
            graph[0].Add(new Edge(0, 2));



			graph[1].Add(new Edge(1, 0));
            graph[1].Add(new Edge(1, 3));

            graph[2].Add(new Edge(2, 0));
            graph[2].Add(new Edge(2, 4));

            graph[3].Add(new Edge(3, 4));
            graph[3].Add(new Edge(3, 1));
			graph[3].Add(new Edge(3, 5));


			graph[4].Add(new Edge(4, 3));
			graph[4].Add(new Edge(4, 2));
			graph[4].Add(new Edge(4, 5));

			graph[5].Add(new Edge(5, 3));
            graph[5].Add(new Edge(5, 4));
			graph[5].Add(new Edge(5, 6));

			graph[6].Add(new Edge(6, 5));

		}

		public int GetNeighboursCount(int node)
        {
            return graph[node].Count;
        }

        public List<int> GetNeighbours(int node)
        {
            return graph[node].ToList().Select(x => x.Destination).ToList();
        }

		/// <summary>
		/////Go to immediate first search
		//once all immediate are traversed then we can move to neighbours of neighbours 
		//indirect level order traversal

		//add item to start search from in queue
		//till queue not empty
		//remvoe from queue
		//check if visited
		//if not mark visited + then print it + then add its neighbours to queue
		//repeat 
		/// </summary>
		/// <param name="graph"></param>
		/// <param name="startPoint"></param>
		public void BFS(int startPoint)
		{
			Queue<int> traveral = new Queue<int>();
            bool[] visited = new bool[vertex];
			traveral.Enqueue(startPoint);

			while (traveral.Count > 0)
			{
				int currentItem = traveral.Dequeue();
				if (!visited[currentItem])
				{
					Console.Write(currentItem + " ");
					visited[currentItem] = true;
                    var immediateNeighbours = GetNeighbours(currentItem);
                    immediateNeighbours.ForEach(x =>
                    {
                        traveral.Enqueue(x);
                    });
				}
			}
		}

        /// <summary>
        /// Keep going to the first neighbour
        /// print
        /// mark visted
        /// and traverse it neighbours 
        /// this can also be implemented using stack and same way as bfs
        /// </summary>
        /// <param name="startPoint"></param>
        public void DFS_Recurssive(int startPoint, bool[] visited)
        {
            Console.Write(startPoint + " ");
            visited[startPoint] = true;

            var neighbours = GetNeighbours(startPoint);
            neighbours.ForEach(x =>
            {
                if (!visited[x])
                    DFS_Recurssive(x, visited);
            });

        }

        public void DFS_Stack(int startPoint)
        {
            Stack<int> traversal = new Stack<int>();
            bool[] visited = new bool[vertex];

            traversal.Push(startPoint);

            while (traversal.Count > 0)
            {
                int currentItem = traversal.Pop();
                if (!visited[currentItem])
                {
                    Console.Write(currentItem + " ");
                    visited[currentItem] = true;
					var immediateNeighbours = GetNeighbours(currentItem);
					immediateNeighbours.ForEach(x =>
					{
                        if (!visited[x])
						    traversal.Push(x);
					});
				}
            }
        }

        public void PathToTarget(bool[] visited, int startPoint, string path, int target)
        {
            if(startPoint == target)
            {
                Console.WriteLine(path);
                return;
            }

            var neighebours = GetNeighbours(startPoint);
            neighebours.ForEach(x =>
            {
                if (!visited[x])
                {
                    visited[startPoint] = true;
                    PathToTarget(visited, x, path+ " -> " + x, target);
                    visited[startPoint] = false;
                }
            });
        }


	}

    public class Edge
    {
        public Edge(int x, int y, int z = 1)
        {
            Source = x;
            Destination = y;
            Weight = z;
        }
        public int Source { get; set; }

        public int Destination { get; set; }

        public int? Weight { get; set; }
    }

}
