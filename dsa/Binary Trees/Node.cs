using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Trees
{
	public class Node
	{
		public int data { get; set; }

		public Node Left { get; set; }

		public Node Right { get; set; }

		public Node(int d)
		{
			data = d;
			Left = null;
			Right = null;
		}
	}
}
