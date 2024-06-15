using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Graphs
{
	public class CustomPriorityQueue<T> where T : IComparable<T>
	{
		private SortedSet<T> set;
		public CustomPriorityQueue()
		{

			set = new SortedSet<T>();
		}

		public void Enqueue(T item)
		{
			set.Add(item);
		}

		public T Dequeue()
		{
			T itemToRemove = set.Min;
			set.Remove(itemToRemove);
			return itemToRemove;

		}
		public int Count()
		{
			return set.Count;
		}

	}

	public class Pair : IComparable<Pair>
	{
		public Pair(int n, int w)
		{
			Node = n;
			Weight = w;
		}
		public int Node { get; set; }
		public int Weight { get; set; }
		public int CompareTo(Pair? other)
		{
			return this.Weight.CompareTo(other?.Weight);
		}
	}
}
