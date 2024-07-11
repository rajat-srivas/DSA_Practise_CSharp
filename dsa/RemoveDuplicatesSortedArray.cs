using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
	internal class RemoveDuplicatesSortedArray
	{

		public void RemoveDup()
		{
			var input = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4};

			var tracker = new Dictionary<int, bool>();

			foreach(int val in input)
			{
				if(!tracker.ContainsKey(val))
				{
					tracker[val] = true;
				}
			}
			int i = 0;
			foreach(var key in tracker)
			{
				input[i] = key.Key;
				i++;
			}

			Console.WriteLine(tracker.Keys.Count.ToString());


			foreach (var item in input)
			{
				Console.Write(item + " ");
			}
		}
	}
}
