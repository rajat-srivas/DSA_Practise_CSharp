using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Graphs
{
	public class ShortestPath
	{
        //Dijkstra's Algorithm
        //BFS
        //greedy

        public Graph graph;
        public ShortestPath()
        {
            graph = new Graph(6);
            graph.CreateGraphForDijkstra();
        }

        public void Dijkstra( int source, int vertex)
		{
            CustomPriorityQueue<Pair> priorityQueue = new CustomPriorityQueue<Pair>();
            priorityQueue.Enqueue(new Pair(source,0)); // distance to itself is 0

            int[] minDistance = new int[vertex];
            for(int i =0;i<vertex; i++) 
            {
                if (i != source)
                {
                    minDistance[i] = int.MaxValue;
                }
            }

            bool[] visisted = new bool[vertex];

            while(priorityQueue.Count() > 0)
            {
                Pair current = priorityQueue.Dequeue();// removes the item with least distance
                Console.WriteLine("Dequeud " + current.Node + " " + current.Weight);
                if (!visisted[current.Node])
                {
                    visisted[current.Node] = true;
                    var neigbours = graph.GetNeighbours(current.Node);
                    neigbours.ForEach(n =>
                    {
                        int u = n.Source;
                        int v = n.Destination;

                       
                        //relaxation method to update distance
                        if (minDistance[u] + n.Weight < minDistance[v]) 
                        {
							Console.WriteLine(u + " " + v + " " + n.Weight);
							minDistance[v] = minDistance[u] + n.Weight;
							Console.WriteLine(minDistance[v]);
							priorityQueue.Enqueue(new Pair(v, minDistance[v]));
                        }
                        
                    });
                }
            }

            for(int i = 0;i<vertex;i++)
            {
                Console.Write("0 - " + i + " ===> ");
                Console.Write(minDistance[i] + " ");
                Console.WriteLine();
            }
		}

	}
}
