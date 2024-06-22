using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
	public class WaterGarden
	{
		//NOT COMPLETE
		public void MinimumTapesToWaterGarden()
		{
			int n = 5;
			int[] ranges = new int[] { 3, 4, 1, 1, 0, 0 };

			var distance = new Dictionary<int, (int left, int right)>();

			for (int i = 0; i < ranges.Length; i++)
			{
				int left = Math.Max(0, (i - ranges[i]));
				int right = Math.Min(n, (i + ranges[i]));

				distance[i] = (left, right);
			}

			List<KeyValuePair<int, (int left, int right)>> list = distance.ToList();

			// Sort the list
			list.Sort((x, y) =>
			{
				// Compare by left, and if lefts are equal, then by right
				int compareLeft = x.Value.left.CompareTo(y.Value.left);
				if (compareLeft != 0)
					return compareLeft;
				else
					return x.Value.right.CompareTo(y.Value.right);
			});

			// Create a new sorted dictionary (if needed)
			Dictionary<int, (int left, int right)> sortedDistance = list.ToDictionary(kv => kv.Key, kv => kv.Value);

			// Print sorted dictionary (for demonstration)
			foreach (var kvp in sortedDistance)
			{
				Console.WriteLine($"Key: {kvp.Key}, Value: ({kvp.Value.left}, {kvp.Value.right})");
			}
		}
	}
}
